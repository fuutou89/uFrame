namespace uFrame.MVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Editor.Configurations;
    using uFrame.Editor.Core;
    using uFrame.Editor.Graphs.Data;
    
    
    public class StateMachineNode : StateMachineNodeBase {
        public override bool UseStraightLines
        {
            get
            {
                return true;
            }
        }

        public IEnumerable<StateNode> States
        {
            get
            {
                return this.Children.OfType<StateNode>();
            }
        }

    }
    
    public partial interface IStateMachineConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
}
