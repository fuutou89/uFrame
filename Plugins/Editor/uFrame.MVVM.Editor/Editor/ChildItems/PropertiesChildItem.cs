using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM
{
    using System;


    public class PropertiesChildItem : PropertiesChildItemBase
    {
        public override Type Type
        {
            get
            {
                return base.Type ?? typeof(int);
            }
        }

        public override string DefaultTypeName
        {
            get { return typeof(int).Name; }
        }
    }

    public partial interface IPropertiesConnectable : IDiagramNodeItem, IConnectable
    {
    }
}
