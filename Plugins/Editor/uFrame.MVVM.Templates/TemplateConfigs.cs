using UnityEngine;
using UnityEditor;
using uFrame.Editor.Compiling.CodeGen;
using uFrame.ECS.Actions;
using uFrame.Editor;
using uFrame.Editor.Core;
using uFrame.IOC;
using uFrame.MVVM.Bindings;
using uFrame.Editor.Graphs.Data;
using System.CodeDom;
using uFrame.MVVM.StateMachines;

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
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<StateMachineNode, StateMachineTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<StateNode, StateTemplate>();
            RegisteredTemplateGeneratorsFactory.RegisterTemplate<ViewComponentNode, ViewComponentTemplate>();

            // Register bindable methods
            container.AddBindingMethod(typeof(ViewBindings), "BindProperty", _ => _ is PropertiesChildItem || _ is ComputedPropertyNode)
                     .SetNameFormat("{0} Changed")
                     .ImplementWith(args =>
                     {
                         var sourceItem = args.SourceItem as ITypedItem;

                         if (sourceItem.RelatedNode() is StateMachineNode)
                         {
                             args.Method.Parameters.Clear();
                             args.Method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(State), "State"));
                         }
                     });

            container.AddBindingMethod(typeof(ViewBindings), "BindCollection", _ => _ is CollectionsChildItem)
                     .SetNameFormat("{0} Collection Changed")
                     .SetDescription("Collection bindings bind to a collection giving you two methods, {CollectionName}Added, and {CollectionName}Removed, override these methods to execute something when the collection is modified.");
        }
    }


}
