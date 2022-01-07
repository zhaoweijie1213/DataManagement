using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumNewUserProvince
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public DateOnly Date { get; set; }
        public int Count { get; set; }
    }
}
