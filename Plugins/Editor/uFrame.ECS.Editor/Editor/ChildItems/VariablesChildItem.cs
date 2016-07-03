using uFrame.Editor.Graphs.Data;
using uFrame.Editor.Graphs.Data.Types;

namespace uFrame.ECS.Editor.ChildItems
{


    public class VariablesChildItem : VariablesChildItemBase, IMemberInfo {
    }
    
    public partial interface IVariablesConnectable : IDiagramNodeItem, IConnectable {
    }
}
