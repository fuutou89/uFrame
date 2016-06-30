namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ModuleNodeDrawer : GenericNodeDrawer<ModuleNode,ModuleNodeViewModel> {
        
        public ModuleNodeDrawer(ModuleNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
