using Invert.Core.GraphDesigner;

namespace Invert.uFrame.MVVM
{
    public class MvvmWorkspace : Workspace
    {
        public override CompilationMode CompilationMode
        {
            get
            {
                return CompilationMode.Always;
            }
        }
    }
}


