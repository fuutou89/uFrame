using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class Vector2NodeViewModel : Vector2NodeViewModelBase {
        
        public Vector2NodeViewModel(Vector2Node graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
