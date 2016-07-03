using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM
{
    using System.Collections.Generic;
    using System.Linq;


    public class ElementNode : ElementNodeBase, IInstancesConnectable, IViewConnectable, IElementConnectable
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

        public IEnumerable<ITypedItem> AllCommandHandlers
        {
            get
            {
                foreach (CommandsChildItem commandsChildItem in this.LocalCommands)
                {
                    yield return commandsChildItem;
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

    public partial interface IElementConnectable : IDiagramNodeItem, IConnectable
    {
    }
}
