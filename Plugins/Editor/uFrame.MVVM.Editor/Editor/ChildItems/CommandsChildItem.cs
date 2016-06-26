namespace uFrame.MVVM
{
    using Invert.Core.GraphDesigner;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Json;

    public class CommandsChildItem : CommandsChildItemBase, IMemberInfo
    {
        //public override string RelatedTypeName
        //{
        //    get
        //    {
        //        if(string.IsNullOrEmpty(RelatedType) || RelatedType == "System.Void")
        //        {
        //            return "[void]";
        //        }
        //        return base.RelatedTypeName;
        //    }
        //}
        public CommandNode OutputCommand
        {
            get
            {
                return this.RelatedTypeNode as CommandNode;
            }
        }

        public string ClassName
        {
            get
            {
                return this.Name + "Command";
            }
        }

        public override string DefaultTypeName
        {
            get
            {
                return typeof(void).FullName;
            }
        }

        [JsonProperty]
        public override string Name
        {
            get
            {
                string name = base.Name;
                if (this.OutputCommand != null)
                {
                    UnityEngine.Debug.Log("! = NULL");
                    name = this.OutputCommand.Name;
                }
                return name;
            }

            set
            {
                base.Name = value;
            }
        }

        public override void RemoveType()
        {
            this.RelatedType = typeof(void).FullName;
            //base.RemoveType();
        }

        //[JsonProperty]
        //public override string Name
        //{
        //    get
        //    {
        //        CommandNode outputCommand = this.OutputCommand;
        //        bool flag = outputCommand != null;
        //        //UnityEngine.Debug.Log("Flag : " + flag);
        //        string name;
        //        if (flag)
        //        {
        //            name = outputCommand.Name;
        //        }
        //        else
        //        {
        //            name = base.GetName();//base.Name;
        //        }
        //        return name;
        //    }
        //    set
        //    {
        //        //UnityEngine.Debug.Log("---- Rename Name ----" + value);
        //        //base.Name = value;
        //        base.SetName(value);
        //    }
        //}

        //public override void BeginEditing()
        //{
        //    bool flag = this.OutputCommand != null;
        //    if (flag)
        //    {
        //        base.IsEditing = false;
        //    }
        //    else
        //    {
        //        base.BeginEditing();
        //    }
        //}
    }

    public partial interface ICommandsConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
