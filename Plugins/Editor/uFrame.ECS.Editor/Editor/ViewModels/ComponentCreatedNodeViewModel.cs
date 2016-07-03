using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class ComponentCreatedNodeViewModel : ComponentCreatedNodeViewModelBase {
        
        public ComponentCreatedNodeViewModel(ComponentCreatedNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
