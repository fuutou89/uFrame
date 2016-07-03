using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class BoolExpressionNodeViewModel : BoolExpressionNodeViewModelBase {
        
        public BoolExpressionNodeViewModel(BoolExpressionNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
