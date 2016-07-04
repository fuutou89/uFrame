using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Editor.Configurations;


    public class ElementNode : ElementNodeBase, IInstancesConnectable, IViewConnectable, IElementConnectable
    {
        // TODO : RelatedElements

        public virtual IEnumerable<ComputedPropertyNode> ComputedProperties
        {
            get
            {
                return this.Children.OfType<ComputedPropertyNode>().Distinct();
            }
        }

        public IEnumerable<InstancesReference> RegisteredInstances
        {
            get
            {
                return this.Graph.AllGraphItems.OfType<InstancesReference>().Where(p => p.SourceIdentifier == this.Identifier).Select(i => i);
            }
        }

        public IEnumerable<ITypedItem> AllProperties
        {
            get
            {
                foreach (ComputedPropertyNode computedPropertyNode in this.ComputedProperties)
                {
                    yield return computedPropertyNode;
                }
                foreach (PropertiesChildItem propertiesChildItem in this.LocalProperties)
                {
                    yield return propertiesChildItem;
                }
            }
        }

        public IEnumerable<ITypedItem> BindableProperties
        {
            get
            {
                foreach (ComputedPropertyNode computedPropertyNode in this.ComputedProperties)
                {
                    yield return computedPropertyNode;
                }
                foreach (PropertiesChildItem propertiesChildItem in this.LocalProperties)
                {
                    yield return propertiesChildItem;
                }
                foreach (CollectionsChildItem collectionsChildItem in this.LocalCollections)
                {
                    yield return collectionsChildItem;
                }
                foreach (CommandsChildItem commandsChildItem in this.LocalCommands)
                {
                    yield return commandsChildItem;
                }
                ElementNode elementNode = this.BaseNode as ElementNode;
                if (elementNode != null)
                {
                    foreach (ITypedItem typedItem in elementNode.BindableProperties)
                    {
                        yield return typedItem;
                    }
                }
            }
        }

        public IEnumerable<ITypedItem> AllPropertiesWithInherited
        {
            get
            {
                ElementNode elementNode = this.BaseNode as ElementNode;
                if (elementNode != null)
                {
                    foreach (ITypedItem typedItem in elementNode.AllProperties)
                    {
                        yield return typedItem;
                    }
                    foreach (ITypedItem typedItem2 in elementNode.AllPropertiesWithInherited)
                    {
                        yield return typedItem2;
                    }
                }
            }
        }

        public virtual IEnumerable<PropertiesChildItem> InheritedProperties
        {
            get
            {
                ElementNode elementNode = this.BaseNode as ElementNode;
                if (elementNode != null)
                {
                    foreach (PropertiesChildItem propertiesChildItem in elementNode.LocalProperties)
                    {
                        yield return propertiesChildItem;
                    }
                    foreach (PropertiesChildItem propertiesChildItem2 in elementNode.InheritedProperties)
                    {
                        yield return propertiesChildItem2;
                    }
                }
            }
        }

        public virtual IEnumerable<CollectionsChildItem> InheritedCollections
        {
            get
            {
                ElementNode elementNode = this.BaseNode as ElementNode;
                if (elementNode != null)
                {
                    foreach (CollectionsChildItem collectionsChildItem in elementNode.LocalCollections)
                    {
                        yield return collectionsChildItem;
                    }
                    foreach (CollectionsChildItem collectionsChildItem2 in elementNode.InheritedCollections)
                    {
                        yield return collectionsChildItem2;
                    }
                }
            }
        }

        public virtual IEnumerable<CommandsChildItem> InheritedCommands
        {
            get
            {
                ElementNode elementNode = this.BaseNode as ElementNode;
                if (elementNode != null)
                {
                    foreach (CommandsChildItem commandsChildItem in elementNode.LocalCommands)
                    {
                        yield return commandsChildItem;
                    }
                    foreach (CommandsChildItem commandsChildItem2 in elementNode.InheritedCommands)
                    {
                        yield return commandsChildItem2;
                    }
                }
            }
        }

        public virtual IEnumerable<CommandsChildItem> InheritedCommandsWithLocal
        {
            get
            {
                foreach (CommandsChildItem commandsChildItem in this.LocalCommands)
                {
                    yield return commandsChildItem;
                }
                ElementNode elementNode = this.BaseNode as ElementNode;
                if (elementNode != null)
                {
                    foreach (CommandsChildItem commandsChildItem2 in elementNode.LocalCommands)
                    {
                        yield return commandsChildItem2;
                    }
                    foreach (CommandsChildItem commandsChildItem3 in elementNode.InheritedCommands)
                    {
                        yield return commandsChildItem3;
                    }
                }
            }
        }

        [Section("Properties", SectionVisibility.Always, OrderIndex = 0, IsNewRow = true)]
        public override IEnumerable<PropertiesChildItem> Properties
        {
            get
            {
                if (this.Graph.CurrentFilter == this)
                {
                    foreach (PropertiesChildItem propertiesChildItem in this.InheritedProperties)
                    {
                        yield return propertiesChildItem;
                    }
                }
                foreach (PropertiesChildItem propertiesChildItem2 in this.LocalProperties)
                {
                    yield return propertiesChildItem2;
                }
            }
        }

        [Section("Collections", SectionVisibility.Always, OrderIndex = 1, IsNewRow = true)]
        public override IEnumerable<CollectionsChildItem> Collections
        {
            get
            {
                if (this.Graph.CurrentFilter == this)
                {
                    foreach (CollectionsChildItem collectionsChildItem in this.InheritedCollections)
                    {
                        yield return collectionsChildItem;
                    }
                }
                foreach (CollectionsChildItem collectionsChildItem2 in this.LocalCollections)
                {
                    yield return collectionsChildItem2;
                }
            }
        }

        [Section("Commands", SectionVisibility.Always, OrderIndex = 3, IsNewRow = true)]
        public override IEnumerable<CommandsChildItem> Commands
        {
            get
            {
                if (this.Graph.CurrentFilter == this)
                {
                    foreach (CommandsChildItem commandsChildItem in this.InheritedCommands)
                    {
                        yield return commandsChildItem;
                    }
                }
                foreach (CommandsChildItem commandsChildItem2 in this.LocalCommands)
                {
                    yield return commandsChildItem2;
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

        public override void Validate(List<ErrorInfo> errors)
        {
            base.Validate(errors);
            ITypedItem[] array = base.ChildItemsWithInherited.OfType<ITypedItem>().ToArray<ITypedItem>();
            ITypedItem[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                ITypedItem typedItem = array2[i];
                ITypedItem[] array3 = array;
                for (int j = 0; j < array3.Length; j++)
                {
                    ITypedItem typedItem2 = array3[j];
                    bool flag = typedItem.Name == typedItem2.Name && typedItem != typedItem2;
                    if (flag)
                    {
                        errors.AddError(string.Format("Duplicate \"{0}\"", typedItem.Name), this);
                    }
                }
            }
        }

    }

    public partial interface IElementConnectable : IDiagramNodeItem, IConnectable
    {
    }
}
