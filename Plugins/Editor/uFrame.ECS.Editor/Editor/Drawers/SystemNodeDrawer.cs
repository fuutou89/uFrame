using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class SystemNodeDrawer : GenericNodeDrawer<SystemNode,SystemNodeViewModel> {
        
        public SystemNodeDrawer(SystemNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
