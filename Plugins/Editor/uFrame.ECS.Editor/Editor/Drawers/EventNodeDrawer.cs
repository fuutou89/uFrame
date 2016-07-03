using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class EventNodeDrawer : GenericNodeDrawer<EventNode,EventNodeViewModel> {
        
        public EventNodeDrawer(EventNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
