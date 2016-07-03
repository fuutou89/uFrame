using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class AllTrueNodeDrawer : GenericNodeDrawer<AllTrueNode,AllTrueNodeViewModel> {
        
        public AllTrueNodeDrawer(AllTrueNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
