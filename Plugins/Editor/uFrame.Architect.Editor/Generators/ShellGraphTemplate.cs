using uFrame.Editor.Compiling.CodeGen;
using uFrame.Editor.Configurations;
using uFrame.Editor.Graphs.Data;

namespace uFrame.Architect.Editor.Generators
{
    using Data;

    [TemplateClass(TemplateLocation.Both, ClassNameFormat = "{0}Graph")]
    public class ShellGraphTemplate : GenericGraphData<GenericNode>, IClassTemplate<ShellGraphTypeNode>
    {
        public string OutputPath
        {
            get { return Path2.Combine("Editor", "Graphs"); }
        }

        public bool CanGenerate
        {
            get { return true; }
        }

        public void TemplateSetup()
        {
            Ctx.TryAddNamespace("Invert.Core.GraphDesigner");
            if (Ctx.IsDesignerFile)
            {
#if UNITY_EDITOR
                Ctx.SetBaseType("GenericGraphData<{0}>", Ctx.Data.RootNode.ClassName);
#else
            Ctx.SetBaseTypeArgument("{0}", Ctx.Data.RootNode.ClassName);
#endif
            }
        }

        public TemplateContext<ShellGraphTypeNode> Ctx { get; set; }
    }
}