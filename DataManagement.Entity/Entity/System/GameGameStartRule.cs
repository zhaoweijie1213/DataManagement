using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameGameStartRule
    {
        public long Id { get; set; }
        public string Rulename { get; set; } = null!;
        public string Rulevalue { get; set; } = null!;
        public long Logid { get; set; }
    }
}
