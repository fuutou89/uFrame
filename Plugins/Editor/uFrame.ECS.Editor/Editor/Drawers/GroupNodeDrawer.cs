using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class GroupNodeDrawer : GenericNodeDrawer<GroupNode, GroupNodeViewModel>
    {
        
        public GroupNodeDrawer(GroupNodeViewModel viewModel) : 
                base(viewModel) {
        }
   
    }
}
