namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class SceneTypeNodeDrawer : GenericNodeDrawer<SceneTypeNode,SceneTypeNodeViewModel> {
        
        public SceneTypeNodeDrawer(SceneTypeNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
