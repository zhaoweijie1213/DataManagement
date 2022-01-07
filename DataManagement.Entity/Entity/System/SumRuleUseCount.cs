using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumRuleUseCount
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public int Areaid { get; set; }
        public int Gameid { get; set; }
        public string Rulename { get; set; } = null!;
        public string Rulevalue { get; set; } = null!;
        public int Count { get; set; }
        public DateOnly Date { get; set; }
    }
}
