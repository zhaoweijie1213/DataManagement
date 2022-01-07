using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class ConfigRulevalueDef
    {
        public int Id { get; set; }
        public int? Gameid { get; set; }
        public string? Rulename { get; set; }
        public string? Rulevalue { get; set; }
        public string? CnRulevalue { get; set; }
    }
}
