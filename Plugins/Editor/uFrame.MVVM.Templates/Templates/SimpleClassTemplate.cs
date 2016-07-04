using System;
using System.Collections.Generic;
using System.Linq;
using uFrame.Editor.Compiling.CodeGen;
using uFrame.Editor.Configurations;
using uFrame.Editor.Core;
using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM.Templates
{
    [TemplateClass(TemplateLocation.Both)]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class SimpleClassTemplate : IClassTemplate<SimpleClassNode>, ITemplateCustomFilename
    {
        public TemplateContext<SimpleClassNode> Ctx { get; set; }

        public string Filename
        {
            get
            {
                if (Ctx.Data.Name == null)
                {
                    throw new Exception(Ctx.Data.Name + " Graph name is empty");
                }
                if (Ctx.IsDesignerFile)
                {
                    return Path2.Combine("SimpleClasses.designer", Ctx.Data.Name + "designer.cs");
                }
                return Path2.Combine("SimpleClasses", Ctx.Data.Name + ".cs");
            }
        }

        public string OutputPath { get { return ""; } }

        public bool CanGenerate { get { return true; } }

        public void TemplateSetup()
        {
            foreach (var property in Ctx.Data.ChildItemsWithInherited.OfType<ITypedItem>())
            {
                var type = InvertApplication.FindTypeByNameExternal(property.RelatedTypeName);
                if (type == null)
                    continue;

                Ctx.TryAddNamespace(type.Namespace);
            }
            Ctx.AddIterator("Property", node => node.Properties);
            Ctx.AddIterator("Collection", node => node.Collections);
        }

    }

    [RequiresNamespace("uFrame.Kernel")]
    [RequiresNamespace("uFrame.MVVM")]
    [RequiresNamespace("uFrame.MVVM.Bindings")]
    [RequiresNamespace("uFrame.Kernel.Serialization")]
    public partial class SimpleClassTemplate
    {
        [ForEach("Properties"), GenerateProperty, WithField]
        public _ITEMTYPE_ _PropertyName_ { get; set; }

        [ForEach("Collections"), GenerateProperty, WithField]
        public List<_ITEMTYPE_> _CollectionName_ { get; set; }
    }
}


