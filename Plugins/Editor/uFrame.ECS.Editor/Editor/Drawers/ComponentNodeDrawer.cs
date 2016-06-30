namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ComponentNodeDrawer : GenericNodeDrawer<ComponentNode,ComponentNodeViewModel> {
        
        public ComponentNodeDrawer(ComponentNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
