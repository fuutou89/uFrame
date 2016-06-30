namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class CommandNodeDrawer : GenericNodeDrawer<CommandNode,CommandNodeViewModel> {
        
        public CommandNodeDrawer(CommandNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
