namespace uFrame.MVVM
{
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;


    public class ElementNode : ElementNodeBase
    {
        public IEnumerable<ITypedItem> AllProperties
        {
            get
            {
                //foreach (ComputedPropertyNode computedPropertyNode in this.ComputedProperties)
                //{
                //    yield return computedPropertyNode;
                //}
                foreach (PropertiesChildItem propertiesChildItem in this.LocalProperties)
                {
                    yield return propertiesChildItem;
                }
            }
        }

        public IEnumerable<PropertiesChildItem> LocalProperties
        {
            get
            {
                return this.PersistedItems.OfType<PropertiesChildItem>();
            }
        }

        public IEnumerable<CollectionsChildItem> LocalCollections
        {
            get
            {
                return this.PersistedItems.OfType<CollectionsChildItem>();
            }
        }


        public IEnumerable<CommandsChildItem> LocalCommands
        {
            get
            {
                return this.PersistedItems.OfType<CommandsChildItem>();
            }
        }

    }

    public partial interface IElementConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
