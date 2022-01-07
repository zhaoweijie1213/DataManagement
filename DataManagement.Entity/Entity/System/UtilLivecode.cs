using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class UtilLivecode
    {
        public uint Id { get; set; }
        public string SysNo { get; set; } = null!;
        /// <summary>
        /// 对应的合码url地址
        /// </summary>
        public string? CodeUrl { get; set; }
        public int CutNum { get; set; }
        public string Tag { get; set; } = null!;
        public DateOnly CreateTime { get; set; }
    }
}
