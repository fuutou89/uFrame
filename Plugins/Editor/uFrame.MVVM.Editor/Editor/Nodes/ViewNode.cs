using System;
using System.Collections.Generic;
using uFrame.Editor.Core;
using uFrame.Editor.Graphs.Data;
using uFrame.IOC;

namespace uFrame.MVVM
{
    public class ViewNode : ViewNodeBase 
    {
        //TODO PossibleBindings

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

		public IEnumerable<string> ClassNameFormats
		{
			get
			{
				yield return "{0}";
				yield return "{0}Base";
				yield break;
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
