using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{ 
    public class StringLiteralNodeViewModel : StringLiteralNodeViewModelBase {
        
        public StringLiteralNodeViewModel(StringLiteralNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
