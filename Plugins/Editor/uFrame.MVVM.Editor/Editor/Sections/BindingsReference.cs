using System;
using System.Collections.Generic;
using uFrame.Editor.Graphs.Data;
using uFrame.IOC;
using uFrame.MVVM.Templates;

namespace uFrame.MVVM
{
    public class BindingsReference : BindingsReferenceBase 
    {
    }
    
    public partial interface IBindingsConnectable : IDiagramNodeItem, IConnectable {
    }
}
