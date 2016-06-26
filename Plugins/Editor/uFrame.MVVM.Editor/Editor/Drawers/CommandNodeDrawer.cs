namespace uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class CommandNodeDrawer : GenericNodeDrawer<CommandNode,CommandNodeViewModel> {
        
        public CommandNodeDrawer(CommandNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
