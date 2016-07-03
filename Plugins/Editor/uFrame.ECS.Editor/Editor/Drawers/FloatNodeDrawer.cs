using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class FloatNodeDrawer : GenericNodeDrawer<FloatNode,FloatNodeViewModel> {
        
        public FloatNodeDrawer(FloatNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
