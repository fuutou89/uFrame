namespace Invert.uFrame.MVVM {
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class MVVMNode : MVVMNodeBase {
    }
    
    public partial interface IMVVMConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
