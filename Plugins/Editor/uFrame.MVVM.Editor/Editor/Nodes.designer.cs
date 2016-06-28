// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrame.MVVM {
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class ServiceNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleHandlers {
            get {
                return this.Repository.AllOf<IHandlersConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("Handlers", SectionVisibility.Always, false, false, typeof(IHandlersConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<HandlersReference> Handlers {
            get {
                return PersistedItems.OfType<HandlersReference>();
            }
        }
    }
    
    public partial interface IServiceConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class SimpleClassNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Properties", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Collections", SectionVisibility.Always, OrderIndex=2, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface ISimpleClassConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class SubSystemNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleInstances {
            get {
                return this.Repository.AllOf<IInstancesConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("Instances", SectionVisibility.Always, false, false, typeof(IInstancesConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<InstancesReference> Instances {
            get {
                return PersistedItems.OfType<InstancesReference>();
            }
        }
    }
    
    public partial interface ISubSystemConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class SceneTypeNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface ISceneTypeConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class ElementNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Commands", SectionVisibility.Always, OrderIndex=3, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CommandsChildItem> Commands {
            get {
                return PersistedItems.OfType<CommandsChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Collections", SectionVisibility.Always, OrderIndex=2, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Properties", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
    }
    
    public partial interface IElementConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class CommandNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Properties", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Collections", SectionVisibility.Always, OrderIndex=2, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface ICommandConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class MVVMNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IMVVMConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
