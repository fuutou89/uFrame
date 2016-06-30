namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ObjectNodeDrawer : GenericNodeDrawer<ObjectNode,ObjectNodeViewModel> {
        
        public ObjectNodeDrawer(ObjectNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
