using System.ComponentModel;
using Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Classes;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Commands
{
    public class QueueRevisionForUninstallCommand : IBackgroundCommand
    {
        public BackgroundWorker Worker { get; set; }
        public UFramePackage Package { get; set; }
        public string Title { get; set; }
    }

}
