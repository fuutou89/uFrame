using System.ComponentModel;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Commands
{
    public class SelectPackageCommand : IBackgroundCommand
    {
        public string Id { get; set; }
        public BackgroundWorker Worker { get; set; }
        public string Title { get; set; }
    }
}
