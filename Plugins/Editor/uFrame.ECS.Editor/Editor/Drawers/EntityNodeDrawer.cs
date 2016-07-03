using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class EntityNodeDrawer : GenericNodeDrawer<EntityNode,EntityNodeViewModel> {
        
        public EntityNodeDrawer(EntityNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
