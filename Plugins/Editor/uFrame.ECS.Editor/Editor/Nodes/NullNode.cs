namespace Invert.uFrame.ECS
{


    public class NullNode : NullNodeBase {
        public override string ValueExpression
        {
            get { return "null"; }
        }
    }
    
    public partial interface INullConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
