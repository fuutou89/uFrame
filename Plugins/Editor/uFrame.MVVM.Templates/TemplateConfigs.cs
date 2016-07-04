using UnityEngine;
using UnityEditor;
using uFrame.Editor.Compiling.CodeGen;
using uFrame.ECS.Actions;
using uFrame.Editor;
using uFrame.Editor.Core;
using uFrame.IOC;

namespace uFrame.MVVM.Templates
{
    [InitializeOnLoad]
    public class MvvmTemplate : DiagramPlugin
    {
        static MvvmTemplate()
        {
            InvertApplication.CachedAssembly(typeof(MvvmTemplate).Assembly);
            InvertApplication.CachedAssembly(typeof(UFAction).Assembly);
            InvertApplication.CachedTypeAssembly(typeof(UFAction).Assembly);
        }

        public override void Initialize(UFrameContainer container)
        {
            base.Initialize(container);
            Debug.Log("---- Initialize MvvmTemplate ----");
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<SubSystemNode, SystemLoaderTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<SubSystemNode, SystemLoaderPartialTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<SceneTypeNode, SceneTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<SceneTypeNode, SceneLoaderTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<SceneTypeNode, SceneSettingsTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<ServiceNode, ServiceTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<SimpleClassNode, SimpleClassTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<ElementNode, ViewModelTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<ElementNode, ViewModelConstructorTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<ElementNode, ControllerTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<CommandsChildItem, ViewModelCommandClassTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<CommandNode, CommandTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<ViewNode, ViewTemplate>();
        }
    }


}
