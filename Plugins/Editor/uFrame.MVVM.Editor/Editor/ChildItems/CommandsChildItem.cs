namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Json;

    public class CommandsChildItem : CommandsChildItemBase, IMemberInfo
    {
        public CommandNode OutputCommand
        {
            get
            {
                return this.RelatedTypeNode as CommandNode;
            }
        }

        public override bool AllowInputs
        {
            get
            {
                return false;
            }
        }

        public string ClassName
        {
            get
            {
                return this.Name + "Command";
            }
        }

        public override string DefaultTypeName
        {
            get
            {
                return typeof(void).FullName;
            }
        }

        [JsonProperty]
        public override string Name
        {
            get
            {
                string name = base.Name;
                if (this.OutputCommand != null)
                {
                    name = this.OutputCommand.Name;
                }
                return name;
            }

            set
            {
                base.Name = value;
            }
        }

        public override void RemoveType()
        {
            base.RemoveType();
            this.RelatedType = typeof(void).FullName;
        }

        public override void BeginEditing()
        {
            if(this.OutputCommand != null)
            {
                base.IsEditing = false;
            }
            else
            {
                base.BeginEditing();
            }
        }
    }

    public partial interface ICommandsConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
