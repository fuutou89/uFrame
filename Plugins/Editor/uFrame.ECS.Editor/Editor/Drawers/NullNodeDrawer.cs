namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class NullNodeDrawer : GenericNodeDrawer<NullNode,NullNodeViewModel> {
        
        public NullNodeDrawer(NullNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
