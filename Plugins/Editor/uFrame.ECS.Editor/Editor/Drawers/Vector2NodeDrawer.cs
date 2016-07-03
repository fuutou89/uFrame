using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class Vector2NodeDrawer : GenericNodeDrawer<Vector2Node,Vector2NodeViewModel> {
        
        public Vector2NodeDrawer(Vector2NodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
