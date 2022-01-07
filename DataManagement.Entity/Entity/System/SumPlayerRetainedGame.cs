﻿using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumPlayerRetainedGame
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public int Areaid { get; set; }
        public int Gameid { get; set; }
        public DateOnly Date { get; set; }
        public int Count { get; set; }
        public int Count3 { get; set; }
        public int Count7 { get; set; }
        public int Count15 { get; set; }
        public int Count30 { get; set; }
    }
}