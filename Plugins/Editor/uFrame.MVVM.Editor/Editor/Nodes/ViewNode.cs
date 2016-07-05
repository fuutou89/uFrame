using System;
using System.Linq;
using System.Collections.Generic;
using uFrame.Editor.Core;
using uFrame.Editor.Graphs.Data;
using uFrame.IOC;
using uFrame.MVVM.Bindings;
using uFrame.MVVM.Templates;

namespace uFrame.MVVM
{
    public class ViewNode : ViewNodeBase 
    {
        //TODO PossibleBindings
        public override IEnumerable<IItem> PossibleBindings
		{
			get
			{
                IEnumerable<ITypedItem> bindableProperties = this.Element.BindableProperties;
                foreach(ITypedItem bp in bindableProperties)
                {
                    KeyValuePair<Tuple<Type, string>, object>[] array = uFrameMVVM.BindingTypes;

                    for(int i = 0; i < array.Length; i++)
                    {
                       uFrameBindingType bindableType = array[i].Value as uFrameBindingType;
                       if(bindableType != null)
                       {
                           if(bindableType.CanBind(bp))
                           {
                               BindingsReference br = this.Bindings.FirstOrDefault(p => p.BindingName == array[i].Key.Item2 
                                                                                        && p.BindingType == bindableType
                                                                                        && p.SourceIdentifier == bp.Identifier);
                               if(br == null)
                               {
                                   yield return new BindingsReference
                                   {
                                       Repository = bp.Repository,
                                       Node = this,
                                       SourceIdentifier = bp.Identifier,
                                       BindingName = array[i].Key.Item2,
                                       BindingType = bindableType
                                   };
                               }
                           }
                       }
                    }
                }
			}
		}

		public bool IsDerivedOnly
		{
			get
			{
				return this.BaseNode != null && this.ElementInputSlot.InputFrom<ElementNode>() == null;
			}
		}

		public ElementNode Element
		{
			get
			{
				ElementNode elementNode = this.ElementInputSlot.InputFrom<ElementNode>();
				ElementNode result;
				if (elementNode == null)
				{
					ViewNode viewNode = this.BaseNode as ViewNode;
					if (viewNode != null)
					{
						result = viewNode.Element;
					}
					else
					{
						result = null;
					}
				}
				else
				{
					result = elementNode;
				}
				return result;
			}
		}

		public IEnumerable<PropertiesChildItem> SceneProperties
		{
			get
			{
				return this.ScenePropertiesInputSlot.InputsFrom<PropertiesChildItem>();
			}
		}

		public override void Validate(List<ErrorInfo> errors)
		{
			base.Validate(errors);
            if (this.Element == null)
            {
                errors.AddError("This view must have an element.", this);
            }
		}
    }
    
    public partial interface IViewConnectable : IDiagramNodeItem, IConnectable {
    }
}
