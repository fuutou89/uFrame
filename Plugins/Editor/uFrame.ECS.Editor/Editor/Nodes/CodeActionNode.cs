using System.Collections.Generic;
using Invert.Core.GraphDesigner;
using uFrame.Editor.Attributes;

namespace Invert.uFrame.ECS
{
    public class CodeActionNode : CodeActionNodeBase {
        [InspectorProperty]
        public override string MetaType
        {
            get { return FullName; }
            set { base.MetaType = value; }
        }

        public override void Validate(List<ErrorInfo> errors)
        {
            //base.Validate(errors);
        }
    }
    
    public partial interface ICodeActionConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
