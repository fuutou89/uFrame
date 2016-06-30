namespace uFrame.Architect.Editor.Data
{
    using Invert.Core.GraphDesigner;

    public interface IShellNodeItem : IConnectable, IDiagramNodeItem
    {
        string ReferenceClassName { get; }
    }
}