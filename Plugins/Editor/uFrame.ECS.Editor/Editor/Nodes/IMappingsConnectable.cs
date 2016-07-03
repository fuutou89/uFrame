using System.Collections.Generic;
using uFrame.ECS.Editor.ChildItems;
using uFrame.Editor.Graphs.Data;

namespace uFrame.ECS.Editor.Nodes
{
    public partial interface IMappingsConnectable : IDiagramNode, IConnectable
    {
        System.Collections.Generic.IEnumerable<ComponentNode> SelectComponents { get; }

        string GetContextItemName(string mappingId);

        string ContextTypeName { get; }

        string SystemPropertyName { get; }

        string EnumeratorExpression { get; }

        IEnumerable<IContextVariable> GetVariables(IFilterInput filterInput);

        string MatchAndSelect(string mappingExpression);

        string DispatcherTypesExpression();
        IEnumerable<PropertiesChildItem> GetObservableProperties();
    }
    
}