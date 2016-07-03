using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class AnyTrueNodeDrawer : GenericNodeDrawer<AnyTrueNode,AnyTrueNodeViewModel> {
        
        public AnyTrueNodeDrawer(AnyTrueNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
