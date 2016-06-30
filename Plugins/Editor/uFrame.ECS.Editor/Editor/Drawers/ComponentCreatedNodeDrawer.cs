namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ComponentCreatedNodeDrawer : GenericNodeDrawer<ComponentCreatedNode,ComponentCreatedNodeViewModel> {
        
        public ComponentCreatedNodeDrawer(ComponentCreatedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
