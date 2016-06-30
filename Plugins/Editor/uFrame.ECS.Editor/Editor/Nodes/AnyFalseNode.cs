namespace Invert.uFrame.ECS
{
    using System.Linq;


    public class AnyFalseNode : AnyFalseNodeBase {
        public override string GetExpression()
        {
            return "(" + string.Join(" || ", ExpressionsInputSlot.Items.OfType<BoolExpressionNode>().Select(p => "!" + p.GetExpression()).ToArray()) + ")";
        }
    }
    
    public partial interface IAnyFalseConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
