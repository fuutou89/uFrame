namespace uFrame.Architect.Editor.Data
{
    using Invert.Core.GraphDesigner;

    public class ShellConnectionDefitionNode
    {
        [InputSlot("Output")]
        public SingleInputSlot<IOutputCapable> OutputItem { get; set; }
        [OutputSlot("Input")]
        public SingleInputSlot<IInputCapable> InputItem { get; set; }
    }
}