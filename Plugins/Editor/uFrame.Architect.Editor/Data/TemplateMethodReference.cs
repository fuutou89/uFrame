namespace uFrame.Architect.Editor.Data
{
    using System.Reflection;

    public class TemplateMethodReference : TemplateReference
    {
        public MethodInfo MethodInfo
        {
            get { return MemberInfo as MethodInfo; }
        }
    }
}