using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{ 
    public class DescriptorNodeViewModel : DescriptorNodeViewModelBase {
        
        public DescriptorNodeViewModel(DescriptorNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
