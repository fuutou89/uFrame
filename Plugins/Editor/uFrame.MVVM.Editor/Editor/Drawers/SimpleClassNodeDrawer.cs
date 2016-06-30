namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class SimpleClassNodeDrawer : GenericNodeDrawer<SimpleClassNode,SimpleClassNodeViewModel> {
        
        public SimpleClassNodeDrawer(SimpleClassNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
