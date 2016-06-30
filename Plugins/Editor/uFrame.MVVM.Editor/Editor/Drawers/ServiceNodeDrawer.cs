namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class ServiceNodeDrawer : GenericNodeDrawer<ServiceNode,ServiceNodeViewModel> {
        
        public ServiceNodeDrawer(ServiceNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
