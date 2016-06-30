namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;
    using Invert.Json;

    public class CommandsChildItem : CommandsChildItemBase, IMemberInfo
    {
        [InspectorProperty]
        public bool Publish
        {
            get
            {
                return base["Publish"];
            }
            set
            {
                base["Publish"] = value;
            }
        }

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

        public override bool CanOutputTo(IConnectable input)
        {
            bool result;
            if(this.OutputTo<IClassTypeNode>() != null)
            {
                result = false;
            }
            else
            {
                result = (!(input is HandlersReference) && base.CanOutputTo(input));
            }
            return result;
            //return base.CanOutputTo(input);
        }
    }

    public partial interface ICommandsConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
