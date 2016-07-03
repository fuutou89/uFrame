using uFrame.Editor.Compiling.CodeGen;

namespace uFrame.ECS.Editor.Nodes
{
    public interface ISetupCodeWriter
    {
        void WriteSetupCode(ISequenceVisitor visitor, TemplateContext ctx);
    }
}