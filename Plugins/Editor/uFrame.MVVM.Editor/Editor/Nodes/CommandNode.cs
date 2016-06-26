namespace uFrame.MVVM
{
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    
    public class CommandNode : CommandNodeBase, IElementConnectable
    {
        public override void Validate(List<ErrorInfo> errors)
        {
            base.Validate(errors);
            bool flag = ConnectableExtensions.ReferenceOf<CommandsChildItem>(this) == null;
            if (flag)
            {
                errors.AddError("This node must be linked to a Element Command, if you want a generic command use a 'SimpleClass'.", this);
            }
        }
    }

    public partial interface ICommandConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
