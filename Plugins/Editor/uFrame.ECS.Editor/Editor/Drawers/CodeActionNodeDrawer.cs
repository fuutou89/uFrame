namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class CodeActionNodeDrawer : GenericNodeDrawer<CodeActionNode,CodeActionNodeViewModel> {
        
        public CodeActionNodeDrawer(CodeActionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
