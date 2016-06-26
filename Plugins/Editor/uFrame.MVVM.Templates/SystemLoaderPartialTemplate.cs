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

namespace uFrame.MVVM.Templates
{
    [TemplateClass(TemplateLocation.DesignerFile, "{0}Loader"), AsPartial]
    [RequiresNamespace("uFrame.Kernel")]
    [WithMetaInfo]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class SystemLoaderPartialTemplate : IClassTemplate<SubSystemNode>, ITemplateCustomFilename 
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

        // Replace by ITemplateCustomFilename's Filename
        public string OutputPath { get { return ""; } }

        public bool CanGenerate { get { return true; } }

        public void TemplateSetup()
        {
            Ctx.CurrentDeclaration.Name = Ctx.Data.Name + "Loader";
            Ctx.CurrentDeclaration.BaseTypes.Clear();
            Ctx.CurrentDeclaration.BaseTypes.Add((Ctx.Data.Name + "LoaderBase").ToCodeReference());
        }
    }
}

