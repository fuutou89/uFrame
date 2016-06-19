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
    [TemplateClass(TemplateLocation.Both, "{0}")]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class SceneTemplate : IClassTemplate<SceneTypeNode>, ITemplateCustomFilename
    {
        public TemplateContext<SceneTypeNode> Ctx{ get; set;}
      
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
                    return Path2.Combine("Scenes.designer", Ctx.Data.Name + ".designer.cs");
                }
                return Path2.Combine("Scenes", Ctx.Data.Name + ".cs");
            }
        }

        public string OutputPath
        {
            get
            {
                return Path2.Combine(Ctx.Data.Title + ".cs");
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
                Ctx.CurrentDeclaration.BaseTypes.Add(typeof(MonoBehaviour).ToCodeReference());
            }
        }


    }

    [ForceBaseType(typeof(Scene))]
    public partial class SceneTemplate
    {
        [GenerateProperty]
        public virtual string DefaultKernelScene
        {
            get
            {
                Ctx.CurrentProperty.Attributes = MemberAttributes.Override | MemberAttributes.Public;
                Ctx._("return \"{0}KernelScene\"", Ctx.Data.Graph.Namespace);
                return null;
            }
        }
    }
}


