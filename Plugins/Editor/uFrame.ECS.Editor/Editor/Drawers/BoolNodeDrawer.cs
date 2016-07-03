using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class BoolNodeDrawer : GenericNodeDrawer<BoolNode,BoolNodeViewModel> {
        
        public BoolNodeDrawer(BoolNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
