namespace Invert.uFrame.ECS
{
    using System.Linq;


    public class AllFalseNode : AllFalseNodeBase {
        public override string ToString()
        {
            return "(" + string.Join(" && ", ExpressionsInputSlot.Items.OfType<BoolExpressionNode>().Select(p => "!" + p.GetExpression()).ToArray()) + ")";
        }
    }
    
    public partial interface IAllFalseConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
