using uFrame.Editor.Compiling.CommonNodes;
using uFrame.Editor.Workspaces;
using uFrame.IOC;
using System;
using System.Linq;
using System.Collections.Generic;
using uFrame.Editor.Core;
using uFrame.MVVM.Templates;
using uFrame.Editor.GraphUI;

namespace uFrame.MVVM
{
    public class uFrameMVVM : uFrameMVVMBase
    {
        static uFrameMVVM()
        {
            InvertApplication.CachedTypeAssembly(typeof(uFrameMVVM).Assembly);
        }

        public override decimal LoadPriority
        {
            get { return 500; }
        }

        public override void Initialize(UFrameContainer container)
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

            uFrameMVVM.BindingTypes = InvertGraphEditor.Container.Instances
                                                       .Where(p => p.Key.Item1 == typeof(uFrameBindingType))
                                                       .ToArray<KeyValuePair<Tuple<Type, string>, object>>();
            
            InvertApplication.Log("----- : " + BindingTypes.Length);
        }

        public static KeyValuePair<Tuple<Type, string>, object>[] BindingTypes;
    }
}
