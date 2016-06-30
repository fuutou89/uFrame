namespace Invert.uFrame.ECS
{
    using Invert.Core.GraphDesigner;


    public class DataNodeDrawer : GenericNodeDrawer<DataNode,DataNodeViewModel> {
        
        public DataNodeDrawer(DataNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
