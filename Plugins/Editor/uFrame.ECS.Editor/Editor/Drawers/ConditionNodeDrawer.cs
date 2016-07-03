using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ConditionNodeDrawer : GenericNodeDrawer<ConditionNode,ConditionNodeViewModel> {
        
        public ConditionNodeDrawer(ConditionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
