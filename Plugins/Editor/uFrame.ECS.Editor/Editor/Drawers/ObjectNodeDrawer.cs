using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ObjectNodeDrawer : GenericNodeDrawer<ObjectNode,ObjectNodeViewModel> {
        
        public ObjectNodeDrawer(ObjectNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
