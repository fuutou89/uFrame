using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class NullNodeDrawer : GenericNodeDrawer<NullNode,NullNodeViewModel> {
        
        public NullNodeDrawer(NullNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
