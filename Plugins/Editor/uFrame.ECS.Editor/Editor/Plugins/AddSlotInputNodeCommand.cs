using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.Core;
using uFrame.Editor.GraphUI.ViewModels;
using UnityEngine;

namespace uFrame.ECS.Editor.Plugins
{
    public class AddSlotInputNodeCommand : Command
    {
        public IContextVariable Variable { get; set; }
        public HandlerNode Handler { get; set; }
        public Vector2 Position { get; set; }
        public ActionIn Input { get; set; }
        public DiagramViewModel DiagramViewModel { get; set; }
    }
}