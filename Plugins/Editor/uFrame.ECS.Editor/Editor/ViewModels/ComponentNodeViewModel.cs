using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{


    public class ComponentNodeViewModel : ComponentNodeViewModelBase {
        
        public ComponentNodeViewModel(ComponentNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }


        public override string IconName
        {
            get
            {
                return ComponentNode != null && !string.IsNullOrEmpty(ComponentNode.CustomIcon)
                    ? ComponentNode.CustomIcon
                    : base.IconName;
            }
        }

        public override string SubTitle
        {
            get
            {
                if (ComponentNode.BlackBoard)
                {
                    return "Black Board Component";
                }
                return base.SubTitle;
            }
        }

        public ComponentNode ComponentNode
        {
            get
            {
                return DataObject as ComponentNode;
            }
        }

        protected override void OnAdd(NodeConfigSectionBase configSection, GenericNodeChildItem item)
        {
            base.OnAdd(configSection, item);
            
        }

        public override NodeColor Color
        {
            get
            {
                if (ComponentNode.BlackBoard)
                {
                    return NodeColor.Black;
                }
                return base.Color;
            }
        }
    }
}
