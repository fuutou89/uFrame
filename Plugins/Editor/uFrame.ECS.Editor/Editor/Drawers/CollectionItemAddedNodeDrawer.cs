using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class CollectionItemAddedNodeDrawer : GenericNodeDrawer<CollectionItemAddedNode,CollectionItemAddedNodeViewModel> {
        
        public CollectionItemAddedNodeDrawer(CollectionItemAddedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
