using uFrame.Editor.Graphs.Data;

namespace uFrame.ECS.Editor.Nodes
{
    public interface ISequenceVisitor
    {
        void Visit(IDiagramNodeItem item);
        
    }
}