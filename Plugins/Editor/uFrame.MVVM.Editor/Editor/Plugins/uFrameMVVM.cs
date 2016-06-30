namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;


    public class uFrameMVVM : uFrameMVVMBase
    {
        public override decimal LoadPriority
        {
            get { return 500; }
        }

        public override void Initialize(Invert.IOC.UFrameContainer container)
        {
            base.Initialize(container);
            SubSystem.Name = "SubSystem";
            SceneType.Name = "Scene Type";
            container.AddWorkspaceConfig<MvvmWorkspace>("MVVM")
                .WithGraph<MVVMGraph>("MVVM", "Create MVVM")
                .WithGraph<SubSystemGraph>("SubSystem", "Create SubSystem");
            MVVM.HasSubNode<TypeReferenceNode>();
            SubSystem.HasSubNode<TypeReferenceNode>();
            SubSystem.HasSubNode<EnumNode>();
        }

    }
}
