using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{
    public class SequenceContainerNodeViewModel : SequenceContainerNodeViewModelBase {
        
        public SequenceContainerNodeViewModel(SequenceContainerNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
