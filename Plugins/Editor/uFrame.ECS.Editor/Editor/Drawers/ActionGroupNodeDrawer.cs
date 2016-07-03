using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    using Nodes;
    using ViewModels;

    public class ActionGroupNodeDrawer : GenericNodeDrawer<ActionGroupNode,ActionGroupNodeViewModel> {
        
        public ActionGroupNodeDrawer(ActionGroupNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
