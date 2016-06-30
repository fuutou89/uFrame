namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


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
