using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ComponentCreatedNodeDrawer : GenericNodeDrawer<ComponentCreatedNode,ComponentCreatedNodeViewModel> {
        
        public ComponentCreatedNodeDrawer(ComponentCreatedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
