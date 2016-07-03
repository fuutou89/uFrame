using System;
using uFrame.Attributes;

namespace uFrame.ECS.Editor.Plugins
{
    public class CustomActionInfo
    {
        public Type Type { get; set; }
        public ActionTitle TitleAttribute { get; set; }
        public uFrameCategory CategoryAttribute { get; set; }
    }
}