using System.ComponentModel;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Commands
{
    public class RefreshFrontPagePackagesCommand : IBackgroundCommand
    {
        public BackgroundWorker Worker { get; set; }
        public string Title { get; set; }
    }
}
