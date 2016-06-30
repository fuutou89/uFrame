namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class ElementNodeDrawer : GenericNodeDrawer<ElementNode,ElementNodeViewModel> {
        
        public ElementNodeDrawer(ElementNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
