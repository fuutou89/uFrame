using System;
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

namespace Invert.uFrame.MVVM.Templates
{
    [TemplateClass(TemplateLocation.Both, "{0}Loader"), AsPartial]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class SystemLoaderTemplate : IClassTemplate<SubSystemNode>, ITemplateCustomFilename
    {
        public TemplateContext<SubSystemNode> Ctx { get; set; }

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
                    return Path2.Combine("Systems.designer", Ctx.Data.Name + "Loader.designer.cs");
                }
                return Path2.Combine("Systems", Ctx.Data.Name + "Loader.cs");
            }
        }

        public string OutputPath
        {
            get
            {
                return Path2.Combine(Ctx.Data.Title + "Loader.cs");
            }
        }

        public bool CanGenerate
        {
            get
            {
                return true;
            }
        }

        public void TemplateSetup()
        {
            if(!Ctx.IsDesignerFile)
            {
                Ctx.CurrentDeclaration.BaseTypes.Clear();
            }
        }
    }

    [ForceBaseType(typeof(SystemLoader))]
    [RequiresNamespace("Invert.IOC")]
    [RequiresNamespace("uFrame.Kernel")]
    [RequiresNamespace("uFrame.MVVM")]
    [RequiresNamespace("UniRx")]
    [RequiresNamespace("UnityEngine")]
    public partial class SystemLoaderTemplate
    {
        [GenerateMethod(CallBase = true), Inside(TemplateLocation.DesignerFile)]
        public void Load()
        {
            Ctx.CurrentMethod.Attributes |= MemberAttributes.Override;
            Ctx.CurrentMethod.invoke_base();
        }
    }
}
