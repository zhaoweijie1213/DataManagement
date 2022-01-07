using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumGameActiveUserApp
    {
        public long Id { get; set; }
        public int Appid { get; set; }
        public int Gameid { get; set; }
        public DateOnly Date { get; set; }
        public int Count { get; set; }
        public int Clubcount { get; set; }
    }
}
