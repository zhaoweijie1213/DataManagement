using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysSystemLog
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public int ActionType { get; set; }
        public string Action { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public DateTime DoTime { get; set; }
        public int State { get; set; }
    }
}
