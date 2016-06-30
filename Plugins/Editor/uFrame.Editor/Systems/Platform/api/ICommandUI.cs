namespace Invert.Core.GraphDesigner
{
    public interface ICommandUI
    {
        void AddCommand(ICommand command);
        void Go();
        
        void GoBottom();
    }
}