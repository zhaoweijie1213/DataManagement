using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumNewUserCity
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public DateOnly Date { get; set; }
        public int Count { get; set; }
    }
}
