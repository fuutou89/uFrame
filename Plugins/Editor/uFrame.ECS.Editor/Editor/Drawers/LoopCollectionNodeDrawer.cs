using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor
{
    public class LoopCollectionNodeDrawer : GenericNodeDrawer<LoopCollectionNode,LoopCollectionNodeViewModel> {
        
        public LoopCollectionNodeDrawer(LoopCollectionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
