namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class SubSystemNodeDrawer : GenericNodeDrawer<SubSystemNode,SubSystemNodeViewModel> {
        
        public SubSystemNodeDrawer(SubSystemNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
