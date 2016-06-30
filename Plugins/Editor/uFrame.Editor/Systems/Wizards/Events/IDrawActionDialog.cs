using System;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Systems.GraphUI
{
    public interface IDrawActionDialog
    {
        void DrawActionDialog(IPlatformDrawer platform, Rect bounds, ActionItem item, Action cancel = null);
    }
}