using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class ActionGroupNodeViewModel : ActionGroupNodeViewModelBase {
        
        public ActionGroupNodeViewModel(ActionGroupNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
