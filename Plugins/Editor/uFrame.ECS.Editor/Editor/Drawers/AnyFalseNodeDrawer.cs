using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class AnyFalseNodeDrawer : GenericNodeDrawer<AnyFalseNode,AnyFalseNodeViewModel> {
        
        public AnyFalseNodeDrawer(AnyFalseNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
