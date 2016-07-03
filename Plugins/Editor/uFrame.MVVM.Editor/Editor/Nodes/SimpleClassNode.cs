using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM
{


    public class SimpleClassNode : SimpleClassNodeBase, IHandlersConnectable {
    }
    
    public partial interface ISimpleClassConnectable : IDiagramNodeItem, IConnectable {
    }
}
