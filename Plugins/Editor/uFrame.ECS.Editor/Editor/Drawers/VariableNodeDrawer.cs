using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class VariableNodeDrawer : GenericNodeDrawer<VariableNode,VariableNodeViewModel> {
        
        public VariableNodeDrawer(VariableNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
