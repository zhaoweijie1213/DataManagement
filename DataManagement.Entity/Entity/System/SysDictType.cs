using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysDictType
    {
        public string SysNo { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string TypeName { get; set; } = null!;
        public string ECode { get; set; } = null!;
        public string ParentSysNo { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int State { get; set; }
        public string ParentNames { get; set; } = null!;
        public string ParentSysNos { get; set; } = null!;
        public string ETypeName { get; set; } = null!;
        /// <summary>
        /// 来源于哪里，1：数据后台，2：代理商后台
        /// </summary>
        public int BackType { get; set; }
    }
}
