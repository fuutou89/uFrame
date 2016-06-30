namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class ViewNodeDrawer : GenericNodeDrawer<ViewNode,ViewNodeViewModel> {
        
        public ViewNodeDrawer(ViewNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
