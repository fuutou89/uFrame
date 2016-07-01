using Invert.Core.GraphDesigner;

namespace uFrame.Architect.Editor.Data
{
    public interface IShellNodeItem : IConnectable, IDiagramNodeItem
    {
        string ReferenceClassName { get; }
    }
}