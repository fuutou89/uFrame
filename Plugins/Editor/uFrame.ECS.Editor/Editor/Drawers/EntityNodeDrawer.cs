namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class EntityNodeDrawer : GenericNodeDrawer<EntityNode,EntityNodeViewModel> {
        
        public EntityNodeDrawer(EntityNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
