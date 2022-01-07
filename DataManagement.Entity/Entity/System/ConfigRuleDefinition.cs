using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class ConfigRuleDefinition
    {
        public int Id { get; set; }
        public int? Gameid { get; set; }
        /// <summary>
        /// 程序定义
        /// </summary>
        public string? ProgramDef { get; set; }
        /// <summary>
        /// 中文定义
        /// </summary>
        public string? CnDef { get; set; }
    }
}
