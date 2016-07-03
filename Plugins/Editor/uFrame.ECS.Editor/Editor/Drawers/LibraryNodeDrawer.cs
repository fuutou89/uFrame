using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class LibraryNodeDrawer : GenericNodeDrawer<LibraryNode,LibraryNodeViewModel> {
        
        public LibraryNodeDrawer(LibraryNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
