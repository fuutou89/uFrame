using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class EnumValueNodeDrawer : GenericNodeDrawer<EnumValueNode,EnumValueNodeViewModel> {
        
        public EnumValueNodeDrawer(EnumValueNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
