namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class MVVMNodeDrawer : GenericNodeDrawer<MVVMNode,MVVMNodeViewModel> {
        
        public MVVMNodeDrawer(MVVMNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
