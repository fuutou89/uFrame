namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;
    using System.Collections.Generic;


    public class CommandNode : CommandNodeBase, IElementConnectable
    {
        public override string TypeName
        {
            get
            {
                return base.TypeName + "Command";
            }
        }
        public override string ClassName
        {
            get
            {
                return base.ClassName + "Command";
            }
        }

        public override void Validate(List<ErrorInfo> errors)
        {
            base.Validate(errors);
            bool flag = ConnectableExtensions.ReferenceOf<CommandsChildItem>(this) == null;
            if (flag)
            {
                errors.AddError("This node must be linked to a Element Command, if you want a generic command use a 'SimpleClass'.", this);
            }
        }

        public override bool EndEditing()
        {
            return base.EndEditing();
        }
    }

    public partial interface ICommandConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
