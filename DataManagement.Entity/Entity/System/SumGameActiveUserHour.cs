using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumGameActiveUserHour
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public int Areaid { get; set; }
        public int Gameid { get; set; }
        public DateOnly Date { get; set; }
        public int Count { get; set; }
        public int Clubcount { get; set; }
        public int Hour { get; set; }
    }
}
