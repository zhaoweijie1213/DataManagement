using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameGameStartScore
    {
        public long Id { get; set; }
        public long Uid { get; set; }
        public string Username { get; set; } = null!;
        public int Scorechange { get; set; }
        public int Scoreall { get; set; }
        public long Detailid { get; set; }
    }
}
