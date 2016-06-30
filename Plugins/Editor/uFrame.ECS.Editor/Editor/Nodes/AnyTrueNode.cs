namespace Invert.uFrame.ECS
{
    using System.Linq;


    public class AnyTrueNode : AnyTrueNodeBase {
        public override string GetExpression()
        {
            return "(" + string.Join(" || ", ExpressionsInputSlot.Items.OfType<BoolExpressionNode>().Select(p => p.GetExpression()).ToArray()) + ")";
        }
    }
    
    public partial interface IAnyTrueConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
