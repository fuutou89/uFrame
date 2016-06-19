namespace Invert.uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class MVVMNodeDrawer : GenericNodeDrawer<MVVMNode,MVVMNodeViewModel> {
        
        public MVVMNodeDrawer(MVVMNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
