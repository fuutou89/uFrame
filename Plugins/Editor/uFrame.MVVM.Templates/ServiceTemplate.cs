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
    [TemplateClass(TemplateLocation.Both)]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class ServiceTemplate : IClassTemplate<ServiceNode>, ITemplateCustomFilename 
    {
        public TemplateContext<ServiceNode> Ctx { get; set; }

        public string Filename
        {
            get
            {
                if (Ctx.Data.Name == null)
                {
                    throw new Exception(Ctx.Data.Name + " Graph name is empty");
                }
                if(Ctx.IsDesignerFile)
                {
                    return Path2.Combine("Services.designer", Ctx.Data.Name + ".designer.cs");
                }
                return Path2.Combine("Service", Ctx.Data.Name + ".cs");
            }
        }

        // Replace by ITemplateCustomFilename's Filename
        public string OutputPath { get { return ""; } }

        public bool CanGenerate { get { return true; } }

        public void TemplateSetup()
        {
            
        }
    }

    [ForceBaseType(typeof(SystemServiceMonoBehavior))]
    [RequiresNamespace("UnityEngine")]
    [RequiresNamespace("UniRx")]
    [RequiresNamespace("Invert.IOC")]
    [RequiresNamespace("uFrame.Kernel")]
    [RequiresNamespace("uFrame.MVVM")]
    public partial class ServiceTemplate
    {
        [GenerateMethod(TemplateLocation.Both, true), AsOverride]
        public void Setup()
        {
            Ctx.CurrentMethod.invoke_base();
            Ctx.CurrentMethod.Comments.Add(new CodeCommentStatement("<summary>", true));
            Ctx.CurrentMethod.Comments.Add(new CodeCommentStatement("This method is invoked whenever the kernel is loading", true));
            Ctx.CurrentMethod.Comments.Add(new CodeCommentStatement("Since the kernel lives throughout the entire lifecycle  of the game, this will only be invoked once.", true));
            Ctx.CurrentMethod.Comments.Add(new CodeCommentStatement("</summary>", true));
            if(Ctx.IsDesignerFile)
            {
                foreach(var command in Ctx.Data.Handlers.Select(p => p.SourceItemObject).OfType<IClassTypeNode>())
                {
                    Ctx._("this.OnEvent<{0}>().Subscribe(this.{1}Handler)", command.ClassName, command.Name);
                }
            }
            else
            {
                Ctx.CurrentMethod.invoke_base();
                Ctx._comment("Use the line below to subscribe to events");
                Ctx._comment("this.OnEvent<MyEvent>().Subscribe(myEventInstance => {{ TODO }});");
            }
        }

        public IEnumerable<IDiagramNodeItem> Handlers
        {
            get{ return Ctx.Data.Handlers.Select(p => p.SourceItemObject); }
        }

        [ForEach("Handlers"), GenerateMethod(CallBase = true), Inside(TemplateLocation.Both)]
        public virtual void _Name_Handler(ViewModelCommand data)
        {
            Ctx.CurrentMethod.Name = Ctx.Item.Name + "Handler";
            Ctx.CurrentMethod.Parameters[0].Type = new CodeTypeReference(Ctx.ItemAs<IClassTypeNode>().ClassName);
            Ctx._comment("Process the commands information. Also, you can publish new events by using the line below.");
            Ctx._comment("this.Publish(new AnotherEvent())");

            Ctx.CurrentMethod.Comments.Add(new CodeCommentStatement("<sumarry>", true));
            Ctx.CurrentMethod.Comments.Add(
                new CodeCommentStatement(string.Format("This method is executed when using this.Publish(new {0}())", 
                    Ctx.ItemAs<IClassTypeNode>().ClassName)));
        }
    }
}


