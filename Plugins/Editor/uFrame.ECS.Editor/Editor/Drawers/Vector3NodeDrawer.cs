using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class Vector3NodeDrawer : GenericNodeDrawer<Vector3Node,Vector3NodeViewModel> {
        
        public Vector3NodeDrawer(Vector3NodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
