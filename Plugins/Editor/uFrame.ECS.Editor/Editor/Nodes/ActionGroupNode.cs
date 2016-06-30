using UnityEngine;

namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ActionGroupNode : ActionGroupNodeBase, IVariableContextProvider {
        public override Color Color
        {
            get { return Color.blue; }
        }

        public override void WriteCode(ISequenceVisitor visitor, TemplateContext ctx)
        {
            //base.WriteCode(visitor, ctx);

        }

    }
    
    public partial interface IActionGroupConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
