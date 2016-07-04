namespace uFrame.MVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Editor.Attributes;
    using uFrame.Editor.Configurations;
    using uFrame.Editor.Core;
    using uFrame.Editor.Graphs.Data;
    using uFrame.Editor.Database.Data;
    using uFrame.Json;
    
    public class ComputedPropertyNode : ComputedPropertyNodeBase, ITypedItem 
    {
        private string _type;

        [JsonProperty]
        public string PropertyType
        {
            get
            {
                return string.IsNullOrEmpty(this._type) ? typeof(bool).Name : this._type;
            }
            set
            {
                this.Changed("PropertyType", ref _type, value);
            }
        }

        public override string RelatedType
        {
            get
            {
                return this.PropertyType;
            }
            set
            {
                this.PropertyType = value;
            }
        }

        [NodeProperty(InspectorType.TypeSelection)]
        public string Type
        {
            get
            {
                return this.RelatedTypeName;
            }
            set
            {
                this.PropertyType = value;
            }
        }

        public override string RelatedTypeName
        {
            get
            {
                string result;
                if (this.Graph != null)
                {
                    IClassTypeNode classTypeNode = this.Graph.AllGraphItems.OfType<IClassTypeNode>().FirstOrDefault((IClassTypeNode p) => p.Identifier == this.PropertyType);
                    if (classTypeNode != null)
                    {
                        result = classTypeNode.ClassName;
                        return result;
                    }
                }
                result = (string.IsNullOrEmpty(this.PropertyType) ? typeof(bool).Name : this.PropertyType);
                return result;
            }
            set
            {
                this.PropertyType = value;
            }
        }
    }
    
    public partial interface IComputedPropertyConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
}
