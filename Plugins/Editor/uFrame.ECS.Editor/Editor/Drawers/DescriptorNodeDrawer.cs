using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class DescriptorNodeDrawer : GenericNodeDrawer<DescriptorNode,DescriptorNodeViewModel> {
        
        public DescriptorNodeDrawer(DescriptorNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
