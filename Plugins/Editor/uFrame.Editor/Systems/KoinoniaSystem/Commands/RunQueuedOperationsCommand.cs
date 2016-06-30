using System.ComponentModel;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Commands
{
    public class RunQueuedOperationsCommand : IBackgroundCommand
    {
        public BackgroundWorker Worker { get; set; }
        public string Title { get; set; }
    }
}
