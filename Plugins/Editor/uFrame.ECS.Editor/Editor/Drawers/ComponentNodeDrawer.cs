using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ComponentNodeDrawer : GenericNodeDrawer<ComponentNode,ComponentNodeViewModel> {
        
        public ComponentNodeDrawer(ComponentNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
