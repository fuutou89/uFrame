using Invert.Core.GraphDesigner;

namespace uFrame.Architect.Editor.Data
{
    public class ShellNodeTypeNodeViewModel : GenericNodeViewModel<ShellNodeTypeNode>
    {
        public ShellNodeTypeNodeViewModel(ShellNodeTypeNode graphItemObject, DiagramViewModel diagramViewModel) : base(graphItemObject, diagramViewModel)
        {
        }

        public override NodeColor Color
        {
            get { return GraphItem.Color; }
        }
    }
}