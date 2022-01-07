using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumPlayerGameCount
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public int Areaid { get; set; }
        public int Gameid { get; set; }
        public long Uid { get; set; }
        public int Playcount { get; set; }
        public DateOnly Date { get; set; }
    }
}
