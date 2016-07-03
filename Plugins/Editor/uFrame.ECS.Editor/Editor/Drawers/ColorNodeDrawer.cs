using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class ColorNodeDrawer : GenericNodeDrawer<ColorNode,ColorNodeViewModel> {
        
        public ColorNodeDrawer(ColorNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
