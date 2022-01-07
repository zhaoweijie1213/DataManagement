using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysArticle
    {
        public long Id { get; set; }
        public int? Typeid { get; set; }
        public long? Sortno { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public long? Clicks { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
