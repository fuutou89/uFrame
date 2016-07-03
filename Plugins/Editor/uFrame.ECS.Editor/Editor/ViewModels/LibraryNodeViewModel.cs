using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class LibraryNodeViewModel : LibraryNodeViewModelBase {
        
        public LibraryNodeViewModel(LibraryNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
