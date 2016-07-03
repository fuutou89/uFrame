using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class PropertyChangedNodeDrawer : GenericNodeDrawer<PropertyChangedNode,PropertyChangedNodeViewModel> {
        
        public PropertyChangedNodeDrawer(PropertyChangedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
