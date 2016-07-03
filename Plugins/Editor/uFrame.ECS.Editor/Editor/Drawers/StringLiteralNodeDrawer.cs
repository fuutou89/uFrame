using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class StringLiteralNodeDrawer : GenericNodeDrawer<StringLiteralNode,StringLiteralNodeViewModel> {
        
        public StringLiteralNodeDrawer(StringLiteralNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
