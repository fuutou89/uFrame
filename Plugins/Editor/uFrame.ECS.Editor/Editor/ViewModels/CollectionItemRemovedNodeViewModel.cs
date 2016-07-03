using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class CollectionItemRemovedNodeViewModel : CollectionItemRemovedNodeViewModelBase {
        
        public CollectionItemRemovedNodeViewModel(CollectionItemRemovedNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
