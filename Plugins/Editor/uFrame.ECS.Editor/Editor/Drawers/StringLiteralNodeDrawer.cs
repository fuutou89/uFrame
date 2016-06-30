namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class StringLiteralNodeDrawer : GenericNodeDrawer<StringLiteralNode,StringLiteralNodeViewModel> {
        
        public StringLiteralNodeDrawer(StringLiteralNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
