using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.Plugins;
using uFrame.Editor.Graphs.Data;
using uFrame.Editor.Graphs.Data.Types;

namespace uFrame.ECS.Editor.ChildItems
{
    using System;
    using System.Collections.Generic;


    public class CollectionsChildItem : CollectionsChildItemBase, IMemberInfo, IDescriptorItem
    {
        public override Type Type
        {
            get { return base.Type ?? typeof(int); }
        }
        public override string RelatedTypeName
        {
            get
            {
                if (Type == uFrameECS.EntityComponentType)
                {
                    return typeof(int).Name;
                }
                return base.RelatedTypeName;
            }
        }

        public IEnumerable<DescriptorNode> Descriptors
        {
            get
            {
                foreach (var item in this.Repository.All<DescriptorNode>())
                {
                    if (this[item.Identifier])
                    {
                        yield return item;
                    }
                }
            }
        }
    }
    
    public partial interface ICollectionsConnectable : IDiagramNodeItem, IConnectable {
    }
}
