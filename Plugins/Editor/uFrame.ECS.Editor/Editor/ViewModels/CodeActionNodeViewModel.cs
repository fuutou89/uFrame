using uFrame.ECS.Editor.Nodes;
using uFrame.Editor.GraphUI.ViewModels;

namespace uFrame.ECS.Editor.ViewModels
{


    public class CodeActionNodeViewModel : CodeActionNodeViewModelBase {
        
        public CodeActionNodeViewModel(CodeActionNode graphItemObject, DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }

        protected override void CreateContent()
        {
            base.CreateContent();
            if (Action.Meta == null)
            {
                ContentItems.Add(new SectionHeaderViewModel()
                {
                    Name = "Please Save And Compile",
                    IsNewLine = true
                });
            }
        }
    }
}
