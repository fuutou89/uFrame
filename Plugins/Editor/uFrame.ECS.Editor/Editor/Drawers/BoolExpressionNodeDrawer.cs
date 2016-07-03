using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class BoolExpressionNodeDrawer : GenericNodeDrawer<BoolExpressionNode,BoolExpressionNodeViewModel> {
        
        public BoolExpressionNodeDrawer(BoolExpressionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
