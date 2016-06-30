using System;
using System.Collections.Generic;
using System.Linq;
using Invert.Core;
using Invert.Core.GraphDesigner;

namespace uFrame.MVVM.Templates
{
    [TemplateClass(TemplateLocation.DesignerFile, ClassNameFormat = "{0}Command"), AsPartial]
    [AutoNamespaces]
    [NamespacesFromItems]
    public partial class CommandTemplate : ViewModelCommand, IClassTemplate<CommandNode>, ITemplateCustomFilename 
    {
        public TemplateContext<CommandNode> Ctx { get; set; }

        public string Filename
        {
            get
            {
                if (Ctx.Data.Name == null)
                {
                    throw new Exception(Ctx.Data.Name + " Graph name is empty");
                }
                return Path2.Combine("Commands.designer", Ctx.Data.Name + "Command.designer.cs");
            }
        }

        // Replace by ITemplateCustomFilename's Filename
        public string OutputPath { get { return ""; } }

        public bool CanGenerate { get { return true; } }

        public void TemplateSetup()
        {
            //Ctx.CurrentDeclaration.BaseTypes.Clear();
            //Ctx.CurrentDeclaration.BaseTypes.Add(new CodeTypeReference("ViewModelCommand"));

            foreach (var property in Ctx.Data.ChildItemsWithInherited.OfType<ITypedItem>())
            {
                var type = InvertApplication.FindTypeByNameExternal(property.RelatedTypeName);
                if (type == null)
                    continue;

                Ctx.TryAddNamespace(type.Namespace);
            }
        }
    }

    [RequiresNamespace("UnityEngine")]
    [RequiresNamespace("uFrame.Kernel")]
    [RequiresNamespace("uFrame.MVVM")]
    [RequiresNamespace("uFrame.MVVM.Bindings")]
    [RequiresNamespace("uFrame.Serialization")]
    public partial class CommandTemplate
    {
        [ForEach("Properties"), GenerateProperty, WithField]
        public _ITEMTYPE_ _PropertyName_ { get; set; }

        [ForEach("Collections"), GenerateProperty, WithField]
        public List<_ITEMTYPE_> _CollectionName_ { get; set; }
    }
}


