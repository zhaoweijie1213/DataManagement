using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameGameStartUser
    {
        public long Id { get; set; }
        public long Uid { get; set; }
        public string Username { get; set; } = null!;
        public int Scoreall { get; set; }
        public long Logid { get; set; }
    }
}
