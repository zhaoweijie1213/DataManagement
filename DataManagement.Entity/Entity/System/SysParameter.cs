using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysParameter
    {
        public string SysNo { get; set; } = null!;
        public string ParamKey { get; set; } = null!;
        public string? ParamValue { get; set; }
        public int? State { get; set; }
    }
}
