using System;

namespace Invert.Core.GraphDesigner
{
    public class LambdaFileSyncCommand : LambdaCommand, IFileSyncCommand
    {
        public LambdaFileSyncCommand(string title, Action action) : base(title, action)
        {
        }
    }
}
