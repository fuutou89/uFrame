using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class AllFalseNodeDrawer : GenericNodeDrawer<AllFalseNode,AllFalseNodeViewModel> {
        
        public AllFalseNodeDrawer(AllFalseNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
