namespace uFrame.Architect.Editor.Generators
{
    using Data;
    using Invert.Core.GraphDesigner;

    public class ShellPluginClassGenerator : GenericNodeGenerator<ShellPluginNode>
    {
        public override void Initialize(CodeFileGenerator codeFileGenerator)
        {
            base.Initialize(codeFileGenerator);
            TryAddNamespace("System.IO");

        }
    }
}