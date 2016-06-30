namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class PropertyNodeDrawer : GenericNodeDrawer<PropertyNode,PropertyNodeViewModel> {
        
        public PropertyNodeDrawer(PropertyNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
