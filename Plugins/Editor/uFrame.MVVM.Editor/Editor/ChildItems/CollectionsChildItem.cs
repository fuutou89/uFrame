using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM
{
    using System;


    public class CollectionsChildItem : CollectionsChildItemBase
    {
        public override Type Type
        {
            get
            {
                return base.Type ?? typeof(int);
            }
        }

        public override bool CanOutputTo(IConnectable input)
        {
            if (this.OutputTo<IClassTypeNode>() != null) return false;
            return base.CanOutputTo(input);
        }

        public override string DefaultTypeName
        {
            get { return typeof(int).Name; }
        }
    }

    public partial interface ICollectionsConnectable : IDiagramNodeItem, IConnectable
    {
    }
}
