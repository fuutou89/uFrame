﻿using System.Collections.Generic;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Systems.GraphUI.api
{
    public interface IDrawDatabasesList
    {
        void DrawDatabasesList(IPlatformDrawer Drawer, Rect bounds, List<DatabasesListItem> items);
    }
}
