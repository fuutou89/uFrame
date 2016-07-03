using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class PropertyNodeDrawer : GenericNodeDrawer<PropertyNode,PropertyNodeViewModel> {
        
        public PropertyNodeDrawer(PropertyNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
