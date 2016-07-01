using Invert.Core.GraphDesigner;

namespace uFrame.Architect.Editor
{
    using Data;
    
    public class ShellPropertySelectorItem : GenericTypedChildItem, IShellNodeItem
    {
        public IShellNode SelectorFor
        {
            get { return this.RelatedNode() as IShellNode; }
        }

        public string ReferenceClassName
        {
            get
            {
                if (SelectorFor == null) return null;
                return SelectorFor.ClassName;
            }
        }
    }
}