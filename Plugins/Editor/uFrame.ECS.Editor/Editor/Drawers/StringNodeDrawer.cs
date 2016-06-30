namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


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
