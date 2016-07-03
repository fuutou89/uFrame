using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class ObjectNodeViewModel : ObjectNodeViewModelBase {
        
        public ObjectNodeViewModel(ObjectNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
