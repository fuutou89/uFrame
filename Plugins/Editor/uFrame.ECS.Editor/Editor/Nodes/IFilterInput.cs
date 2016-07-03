using uFrame.Editor.Graphs.Data;

namespace uFrame.ECS.Editor.Nodes
{
    public interface IFilterInput : IDiagramNodeItem
    {
        string HandlerPropertyName { get;  }
        IMappingsConnectable FilterNode { get; }
        string MappingId { get; }
        // IEnumerable<IContextVariable> GetVariables();
    }
}