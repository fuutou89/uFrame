using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class DataNodeDrawer : GenericNodeDrawer<DataNode,DataNodeViewModel> {
        
        public DataNodeDrawer(DataNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
