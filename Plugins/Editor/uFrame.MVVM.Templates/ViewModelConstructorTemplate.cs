using System;
using System.CodeDom;
using UnityEngine;
using System.ComponentModel;
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
    using uFrame.Graphs;

    [TemplateClass(TemplateLocation.DesignerFile, ClassNameFormat = uFrameFormats.VIEW_MODEL_FORMAT), AsPartial]
    public partial class ViewModelConstructorTemplate : IClassTemplate<ElementNode>, ITemplateCustomFilename
    {
        public TemplateContext<ElementNode> Ctx { get; set; }

        public string Filename
        {
            get
            {
                if (Ctx.Data.Name == null)
                {
                    throw new Exception(Ctx.Data.Name + " Graph name is empty");
                }
                return Path2.Combine("ViewModels.designer", Ctx.Data.Name + "ViewModel.designer.cs");
            }
        }

        // Replace by ITemplateCustomFilename's Filename
        public string OutputPath { get { return ""; } }

        public bool CanGenerate { get { return true; } }

        public void TemplateSetup()
        {
            // Ensure the namespaces for each property type are property set up
            Ctx.CurrentDeclaration.BaseTypes.Clear();
            Ctx.CurrentDeclaration.Name = string.Format(uFrameFormats.VIEW_MODEL_FORMAT, Ctx.Data.Name);
        }
    }

    [RequiresNamespace("uFrame.Kernel")]
    [RequiresNamespace("uFrame.MVVM")]
    [RequiresNamespace("uFrame.Serialization")]
    public partial class ViewModelConstructorTemplate
    {
        [GenerateConstructor("aggregator")]
        public void AggregatorConstructor(IEventAggregator aggregator)
        {

        }
    }
}
