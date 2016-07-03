using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class StartTimerNodeDrawer : GenericNodeDrawer<StartTimerNode,StartTimerNodeViewModel> {
        
        public StartTimerNodeDrawer(StartTimerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
