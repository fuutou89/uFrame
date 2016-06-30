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

    public partial interface IPropertiesConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
