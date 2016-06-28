namespace uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class ViewNodeDrawer : GenericNodeDrawer<ViewNode,ViewNodeViewModel> {
        
        public ViewNodeDrawer(ViewNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
