using Invert.Core.GraphDesigner;

namespace uFrame.Architect.Editor.Generators
{
    using Data;

    public class ShellPluginClassGenerator : GenericNodeGenerator<ShellPluginNode>
    {
        public override void Initialize(CodeFileGenerator codeFileGenerator)
        {
            base.Initialize(codeFileGenerator);
            TryAddNamespace("System.IO");

        }
    }
}