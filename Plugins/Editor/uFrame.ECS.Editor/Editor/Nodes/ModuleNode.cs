using Invert.Core.GraphDesigner;
using uFrame.Editor.Attributes;

namespace Invert.uFrame.ECS
{
    public class ModuleNode : ModuleNodeBase, IAlwaysGenerate {
        public override bool AllowOutputs
        {
            get { return false; }
        }
        public override bool AllowInputs
        {
            get { return false; }
        }
    
    }
    
    public partial interface IModuleConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
