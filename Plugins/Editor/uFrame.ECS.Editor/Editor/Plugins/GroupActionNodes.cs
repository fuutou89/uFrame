using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.Core;
using uFrame.Editor.Graphs.Data;

namespace uFrame.ECS.Editor.Plugins
{
    public class GroupActionNodes : Command
    {
        public IDiagramNodeItem[] Items;
        public SequenceItemNode Node { get; set; }
    }
}