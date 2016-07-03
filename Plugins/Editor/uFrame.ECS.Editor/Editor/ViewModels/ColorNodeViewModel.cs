using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class ColorNodeViewModel : ColorNodeViewModelBase {
        
        public ColorNodeViewModel(ColorNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
