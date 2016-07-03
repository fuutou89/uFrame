using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class SequenceContainerNodeDrawer : GenericNodeDrawer<SequenceContainerNode,SequenceContainerNodeViewModel> {
        
        public SequenceContainerNodeDrawer(SequenceContainerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
