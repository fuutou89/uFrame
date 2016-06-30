namespace uFrame.Architect.Editor.Data
{
    using Invert.Core.GraphDesigner;
    using Invert.Json;

    public class ShellNodeTypeSection : ShellNode, IShellNode
    {
        [JsonProperty]
        public bool AllowAdding { get; set; }



        public override string ClassName
        {
            get { return this.Name + "Reference"; }
        }
        [JsonProperty, InspectorProperty]
        public SectionVisibility Visibility { get; set; }

        public virtual string ReferenceClassName
        {
            get { return "I" + this.Name; }
        }
    }
}