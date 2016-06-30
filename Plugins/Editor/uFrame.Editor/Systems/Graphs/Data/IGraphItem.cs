using Invert.Data;

namespace Invert.Core.GraphDesigner
{
    public interface IGraphItem : IItem, IDataRecord
    {
        string Label { get; }
        bool IsValid { get; }


    }

     
}