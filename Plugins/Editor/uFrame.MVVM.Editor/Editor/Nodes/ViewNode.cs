namespace uFrame.MVVM {
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class ViewNode : ViewNodeBase {
    }
    
    public partial interface IViewConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
