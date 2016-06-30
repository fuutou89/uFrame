namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ComponentDestroyedNodeDrawer : GenericNodeDrawer<ComponentDestroyedNode,ComponentDestroyedNodeViewModel> {
        
        public ComponentDestroyedNodeDrawer(ComponentDestroyedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
