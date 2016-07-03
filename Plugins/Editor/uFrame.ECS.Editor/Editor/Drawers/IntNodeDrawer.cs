using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class IntNodeDrawer : GenericNodeDrawer<IntNode,IntNodeViewModel> {
        
        public IntNodeDrawer(IntNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
