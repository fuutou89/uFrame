namespace uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class ServiceNodeDrawer : GenericNodeDrawer<ServiceNode,ServiceNodeViewModel> {
        
        public ServiceNodeDrawer(ServiceNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
