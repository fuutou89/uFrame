namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class SystemNodeDrawer : GenericNodeDrawer<SystemNode,SystemNodeViewModel> {
        
        public SystemNodeDrawer(SystemNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
