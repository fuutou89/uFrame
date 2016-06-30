namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class PropertyChangedNodeDrawer : GenericNodeDrawer<PropertyChangedNode,PropertyChangedNodeViewModel> {
        
        public PropertyChangedNodeDrawer(PropertyChangedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
