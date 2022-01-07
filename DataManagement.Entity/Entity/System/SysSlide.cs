using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysSlide
    {
        public int Id { get; set; }
        public int Typeid { get; set; }
        public int Gameid { get; set; }
        public string Title { get; set; } = null!;
        public string? Picture { get; set; }
        public string Content { get; set; } = null!;
        public string? Url { get; set; }
        public DateTime Createtime { get; set; }
        public int Clicks { get; set; }
        public int Sortno { get; set; }
    }
}
