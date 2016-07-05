using System;
using System.Linq;
using System.Collections.Generic;
using uFrame.Editor.Graphs.Data;
using uFrame.IOC;
using uFrame.Json;
using uFrame.MVVM.Templates;
using uFrame.Editor.Core;

namespace uFrame.MVVM
{
    public class BindingsReference : BindingsReferenceBase 
    {
        private uFrameBindingType _bindingType;

        public override bool AllowInputs
        {
            get
            {
                return false;
            }
        }

        [JsonProperty]
        public string BindingName
        {
            get;
            set;
        }

        public override string Name
        {
            get
            {
                return this.Title;
            }
            set
            {
                base.Name = value;
            }
        }

        public uFrameBindingType BindingType
        {
            get
			{
				uFrameBindingType bindingType = this._bindingType;
				if (bindingType == null)
				{
                    bindingType = uFrameMVVM.BindingTypes
                                            .Where(p => p.Key.Item2 == this.BindingName)
                                            .Select(p => p.Value)
                                            .FirstOrDefault<object>() as uFrameBindingType;
				}
				return bindingType;
			}
            set
            {
                this._bindingType = value;
            }
        }

        public override string Title
        {
            get
            {
                string result;
                if (base.SourceItem == null)
                {
                    result = "Error: Bindable Not Found";
                }
                else
                {
                    result = string.Format(this.BindingType.DisplayFormat, base.SourceItem.Name);
                }
                return result;
            }
        }

        public override string Group
        {
            get
            {
                return string.Format(this.BindingType.DisplayFormat, "{Item}");
            }
        }
    }
    
    public partial interface IBindingsConnectable : IDiagramNodeItem, IConnectable, IItem, ISelectable {
    }
}
