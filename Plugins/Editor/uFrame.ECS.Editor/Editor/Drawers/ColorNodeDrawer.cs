namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class ColorNodeDrawer : GenericNodeDrawer<ColorNode,ColorNodeViewModel> {
        
        public ColorNodeDrawer(ColorNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
