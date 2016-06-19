namespace Invert.uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SubSystemNodeDrawer : GenericNodeDrawer<SubSystemNode,SubSystemNodeViewModel> {
        
        public SubSystemNodeDrawer(SubSystemNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
