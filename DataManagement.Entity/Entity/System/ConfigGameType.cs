using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class ConfigGameType
    {
        public int Id { get; set; }
        public int? Gameid { get; set; }
        public string? Title { get; set; }
        public int? Codeno { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
