using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{ 
    public class ModuleNodeViewModel : ModuleNodeViewModelBase {
        
        public ModuleNodeViewModel(ModuleNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
