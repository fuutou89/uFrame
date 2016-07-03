using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class StopTimerNodeDrawer : GenericNodeDrawer<StopTimerNode, StopTimerNodeViewModel>
    {

        public StopTimerNodeDrawer(StopTimerNodeViewModel viewModel) :
                base(viewModel)
        {
        }
    }
}
