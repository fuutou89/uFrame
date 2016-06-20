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
    [TemplateClass(TemplateLocation.Both, "{0}Loader")]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class SceneLoaderTemplate : IClassTemplate<SceneTypeNode>, ITemplateCustomFilename 
    {
        public TemplateContext<SceneTypeNode> Ctx { get; set;}

        public string Filename
        {
            get
            {
                if(Ctx.Data.Name == null)
                {
                    throw new Exception(Ctx.Data.Name + " Graph name is empty");
                }
                if(Ctx.IsDesignerFile)
                {
                    return Path2.Combine("Scenes.designer", Ctx.Data.Name + "Loader.designer.cs");
                }
                return Path2.Combine("Scenes", Ctx.Data.Name + "Loader.cs");
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
            if(Ctx.IsDesignerFile)
            {
                Ctx.CurrentDeclaration.BaseTypes.Clear();
                Ctx.CurrentDeclaration.BaseTypes.Add(string.Format("SceneLoader<{0}>", Ctx.Data.Name));
            }
        }
    }
       
    [RequiresNamespace("Invert.IOC")]
    [RequiresNamespace("uFrame.Kernel")]
    [RequiresNamespace("uFrame.MVVM")]
    [RequiresNamespace("uFrame.Serialization")]
    [RequiresNamespace("UnityEngine")]
    public partial class SceneLoaderTemplate
    {
        protected virtual void LoadScene(object scene, object progressDelegate)
        {
        }
    }
}

