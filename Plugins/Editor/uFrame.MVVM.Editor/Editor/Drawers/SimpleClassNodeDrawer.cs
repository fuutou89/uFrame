namespace uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SimpleClassNodeDrawer : GenericNodeDrawer<SimpleClassNode,SimpleClassNodeViewModel> {
        
        public SimpleClassNodeDrawer(SimpleClassNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
