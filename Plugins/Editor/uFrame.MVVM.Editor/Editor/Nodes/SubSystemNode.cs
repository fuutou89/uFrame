using System.Collections.Generic;
using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM
{
    public class SubSystemNode : SubSystemNodeBase
    {
        public override bool AllowInputs
        {
            get { return false; }
        }

        public override bool AllowOutputs
        {
            get { return false; }
        }

        public virtual IEnumerable<InstancesReference> AvailableInstances
        {
            get
            {
                foreach (var item in Instances)
                {
                    yield return item;
                }
            }
        }
    }

    public partial interface ISubSystemConnectable : IDiagramNodeItem, IConnectable
    {
    }
}
