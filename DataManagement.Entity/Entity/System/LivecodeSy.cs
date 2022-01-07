using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class LivecodeSy
    {
        public string SysNo { get; set; } = null!;
        public string UtilName { get; set; } = null!;
        public int GameId { get; set; }
        public int State { get; set; }
        public int AreaId { get; set; }
        public string? UtilCodeUrl { get; set; }
        public DateOnly CreateTime { get; set; }
    }
}
