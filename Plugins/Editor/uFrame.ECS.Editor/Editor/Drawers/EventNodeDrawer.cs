namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class EventNodeDrawer : GenericNodeDrawer<EventNode,EventNodeViewModel> {
        
        public EventNodeDrawer(EventNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
