using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class CollectionModifiedHandlerNodeDrawer : GenericNodeDrawer<CollectionModifiedHandlerNode,CollectionModifiedHandlerNodeViewModel> {
        
        public CollectionModifiedHandlerNodeDrawer(CollectionModifiedHandlerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
