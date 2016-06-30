using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    using System.Collections.Generic;


    public class SetVariableNodeViewModel : SetVariableNodeViewModelBase {
        public override IEnumerable<string> Tags
        {
            get { yield break; }
        }

        public override INodeStyleSchema StyleSchema
        {
            get
            {
                return NormalStyleSchema;
            }
        }

        public override string Name
        {
            get { return "Set"; }
            set { base.Name = value; }
        }

        public SetVariableNodeViewModel(SetVariableNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
