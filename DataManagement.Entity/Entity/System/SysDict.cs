using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysDict
    {
        public string SysNo { get; set; } = null!;
        public string TypeSysNo { get; set; } = null!;
        public string ParentSysNo { get; set; } = null!;
        public string Dictname { get; set; } = null!;
        public string ECode { get; set; } = null!;
        public int State { get; set; }
        public string Remark { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string ParentSysNos { get; set; } = null!;
        public string ParentNames { get; set; } = null!;
        public int DictValue { get; set; }
    }
}
