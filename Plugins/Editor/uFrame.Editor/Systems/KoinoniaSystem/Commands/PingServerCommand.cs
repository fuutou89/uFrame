using System.ComponentModel;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Commands
{
    public class PingServerCommand : IBackgroundCommand
    {
        public BackgroundWorker Worker { get; set; }
        public string Server { get; set; }
        public string Title { get; set; }
    }
}
