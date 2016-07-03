using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class UserMethodNodeDrawer : GenericNodeDrawer<UserMethodNode,UserMethodNodeViewModel> {
        
        public UserMethodNodeDrawer(UserMethodNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
