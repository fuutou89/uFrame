// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrame.MVVM {
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class HandlersReferenceBase : Invert.Core.GraphDesigner.GenericReferenceItem<IHandlersConnectable> {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IHandlersConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
