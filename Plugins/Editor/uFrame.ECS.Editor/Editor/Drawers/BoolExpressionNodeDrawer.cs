namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class BoolExpressionNodeDrawer : GenericNodeDrawer<BoolExpressionNode,BoolExpressionNodeViewModel> {
        
        public BoolExpressionNodeDrawer(BoolExpressionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
