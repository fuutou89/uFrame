﻿using System;
using System.CodeDom;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Invert.Core;
using Invert.Core.GraphDesigner;
using Invert.IOC;
using uFrame.Actions;
using uFrame.Attributes;
using uFrame.Kernel;
using uFrame.MVVM;
using UnityEditor;

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
        }
    }


}
