namespace Invert.uFrame.MVVM
{
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    
    public class uFrameMVVM : uFrameMVVMBase
    {
        public override decimal LoadPriority
        {
            get { return 500; }
        }

        public override void Initialize(Invert.IOC.UFrameContainer container)
        {
            base.Initialize(container);
            container.AddWorkspaceConfig<MvvmWorkspace>("MVVM");
        }

    }
}
