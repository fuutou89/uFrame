using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ComponentDestroyedNodeDrawer : GenericNodeDrawer<ComponentDestroyedNode,ComponentDestroyedNodeViewModel> {
        
        public ComponentDestroyedNodeDrawer(ComponentDestroyedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
