using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ModuleNodeDrawer : GenericNodeDrawer<ModuleNode,ModuleNodeViewModel> {
        
        public ModuleNodeDrawer(ModuleNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
