namespace uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SceneTypeNodeDrawer : GenericNodeDrawer<SceneTypeNode,SceneTypeNodeViewModel> {
        
        public SceneTypeNodeDrawer(SceneTypeNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
