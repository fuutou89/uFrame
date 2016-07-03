using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class FunctionNodeDrawer : GenericNodeDrawer<FunctionNode,FunctionNodeViewModel> {
        
        public FunctionNodeDrawer(FunctionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
