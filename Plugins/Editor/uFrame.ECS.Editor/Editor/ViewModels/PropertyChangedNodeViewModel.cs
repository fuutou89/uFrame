using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{


    public class PropertyChangedNodeViewModel : PropertyChangedNodeViewModelBase {
        
        public PropertyChangedNodeViewModel(PropertyChangedNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }

        public PropertyChangedNode PropertyChangedNode
        {
            get { return GraphItemObject as PropertyChangedNode; }
        }

        public override bool AutoAddProperties
        {
            get { return false; }
        }

        protected override void CreateContent()
        {
            base.CreateContent();
            //if (PropertyChangedNode.EntityGroup.Item != null)
            //{
            if (IsVisible(SectionVisibility.WhenNodeIsNotFilter))
            {
                var propertySelection = new InputOutputViewModel()
                {
                    DataObject = PropertyChangedNode.PropertyIn,
                    Name = "Property",
                    IsInput = true,
                    IsOutput = false,
                    IsNewLine = true,
                    AllowSelection = true
                };
                ContentItems.Add(propertySelection);
                AddPropertyFields();
            }
              
            //}
           
        
        }



        public PropertyChangedNode ChangedNode
        {
            get { return GraphItem as PropertyChangedNode; }
        }

    }
}
