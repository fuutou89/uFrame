using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class LiteralNodeDrawer : GenericNodeDrawer<LiteralNode,LiteralNodeViewModel> {
        
        public LiteralNodeDrawer(LiteralNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
