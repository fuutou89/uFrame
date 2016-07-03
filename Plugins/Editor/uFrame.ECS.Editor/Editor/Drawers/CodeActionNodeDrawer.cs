using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class CodeActionNodeDrawer : GenericNodeDrawer<CodeActionNode,CodeActionNodeViewModel> {
        
        public CodeActionNodeDrawer(CodeActionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
