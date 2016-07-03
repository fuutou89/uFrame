using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class ComponentDestroyedNodeViewModel : ComponentDestroyedNodeViewModelBase {
        
        public ComponentDestroyedNodeViewModel(ComponentDestroyedNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
