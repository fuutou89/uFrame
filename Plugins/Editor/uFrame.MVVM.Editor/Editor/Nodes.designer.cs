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
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Editor.Configurations;
    using uFrame.Editor.Core;
    using uFrame.Editor.Graphs.Data;
    
    
    public class ServiceNodeBase : uFrame.Editor.Graphs.Data.GenericInheritableNode, uFrame.Editor.Graphs.Data.IClassTypeNode {
        
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
        
        public virtual System.Collections.Generic.IEnumerable<uFrame.Editor.Core.IItem> PossibleHandlers {
            get {
                return this.Repository.AllOf<IHandlersConnectable>().Cast<IItem>();
            }
        }
        
        [uFrame.Editor.Configurations.ReferenceSection("Handlers", SectionVisibility.Always, false, false, typeof(IHandlersConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<HandlersReference> Handlers {
            get {
                return PersistedItems.OfType<HandlersReference>();
            }
        }
    }
    
    public partial interface IServiceConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class SimpleClassNodeBase : uFrame.Editor.Graphs.Data.GenericInheritableNode, uFrame.Editor.Graphs.Data.IClassTypeNode {
        
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
        
        [uFrame.Editor.Configurations.Section("Properties", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [uFrame.Editor.Configurations.Section("Collections", SectionVisibility.Always, OrderIndex=2, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface ISimpleClassConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class SubSystemNodeBase : uFrame.Editor.Graphs.Data.GenericNode {
        
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
        
        public virtual System.Collections.Generic.IEnumerable<uFrame.Editor.Core.IItem> PossibleInstances {
            get {
                return this.Repository.AllOf<IInstancesConnectable>().Cast<IItem>();
            }
        }
        
        [uFrame.Editor.Configurations.ReferenceSection("Instances", SectionVisibility.Always, false, false, typeof(IInstancesConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<InstancesReference> Instances {
            get {
                return PersistedItems.OfType<InstancesReference>();
            }
        }
    }
    
    public partial interface ISubSystemConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class ViewNodeBase : uFrame.Editor.Graphs.Data.GenericInheritableNode, uFrame.Editor.Graphs.Data.IClassTypeNode {
        
        private string _ElementInputSlotId;
        
        private string _ScenePropertiesInputSlotId;
        
        private Element _Element;
        
        private SceneProperties _SceneProperties;
        
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
        
        public virtual System.Collections.Generic.IEnumerable<uFrame.Editor.Core.IItem> PossibleBindings {
            get {
                return this.Repository.AllOf<IBindingsConnectable>().Cast<IItem>();
            }
        }
        
        [uFrame.Editor.Configurations.ReferenceSection("Bindings", SectionVisibility.Always, false, false, typeof(IBindingsConnectable), false, OrderIndex=3, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<BindingsReference> Bindings {
            get {
                return PersistedItems.OfType<BindingsReference>();
            }
        }
        
        [uFrame.Json.JsonProperty()]
        public virtual string ElementInputSlotId {
            get {
                if (_ElementInputSlotId == null) {
                    _ElementInputSlotId = Guid.NewGuid().ToString();
                }
                return _ElementInputSlotId;
            }
            set {
                _ElementInputSlotId = value;
            }
        }
        
        [uFrame.Json.JsonProperty()]
        public virtual string ScenePropertiesInputSlotId {
            get {
                if (_ScenePropertiesInputSlotId == null) {
                    _ScenePropertiesInputSlotId = Guid.NewGuid().ToString();
                }
                return _ScenePropertiesInputSlotId;
            }
            set {
                _ScenePropertiesInputSlotId = value;
            }
        }
        
        [uFrame.Editor.Configurations.InputSlot("Element", false, SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual Element ElementInputSlot {
            get {
                if (Repository == null) {
                    return null;
                }
                if (_Element != null) {
                    return _Element;
                }
                return _Element ?? (_Element = new Element() { Repository = Repository, Node = this, Identifier = ElementInputSlotId });
            }
        }
        
        [uFrame.Editor.Configurations.InputSlot("Scene Properties", true, SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual SceneProperties ScenePropertiesInputSlot {
            get {
                if (Repository == null) {
                    return null;
                }
                if (_SceneProperties != null) {
                    return _SceneProperties;
                }
                return _SceneProperties ?? (_SceneProperties = new SceneProperties() { Repository = Repository, Node = this, Identifier = ScenePropertiesInputSlotId });
            }
        }
    }
    
    public partial interface IViewConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class SceneTypeNodeBase : uFrame.Editor.Graphs.Data.GenericInheritableNode, uFrame.Editor.Graphs.Data.IClassTypeNode {
        
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
    
    public partial interface ISceneTypeConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class ElementNodeBase : uFrame.Editor.Graphs.Data.GenericInheritableNode, uFrame.Editor.Graphs.Data.IClassTypeNode, IElementConnectable {
        
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
        
        [uFrame.Editor.Configurations.Section("Commands", SectionVisibility.Always, OrderIndex=3, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CommandsChildItem> Commands {
            get {
                return PersistedItems.OfType<CommandsChildItem>();
            }
        }
        
        [uFrame.Editor.Configurations.Section("Collections", SectionVisibility.Always, OrderIndex=2, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
        
        [uFrame.Editor.Configurations.Section("Properties", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
    }
    
    public partial interface IElementConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class CommandNodeBase : uFrame.Editor.Graphs.Data.GenericInheritableNode, uFrame.Editor.Graphs.Data.IClassTypeNode {
        
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
        
        [uFrame.Editor.Configurations.Section("Properties", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [uFrame.Editor.Configurations.Section("Collections", SectionVisibility.Always, OrderIndex=2, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface ICommandConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class MVVMNodeBase : uFrame.Editor.Graphs.Data.GenericNode {
        
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
    
    public partial interface IMVVMConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class ComputedPropertyNodeBase : uFrame.Editor.Graphs.Data.GenericNode {
        
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
    
    public partial interface IComputedPropertyConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
}
