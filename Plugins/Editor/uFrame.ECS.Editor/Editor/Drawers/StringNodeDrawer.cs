using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class StringNodeDrawer : GenericNodeDrawer<StringNode,StringNodeViewModel> {
        public override float Width
        {
            get { return 500f; }
        }

        public StringNodeDrawer(StringNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
