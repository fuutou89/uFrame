using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class HandlerNodeDrawer : GenericNodeDrawer<HandlerNode,HandlerNodeViewModel> {
  
        public HandlerNodeDrawer(HandlerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
