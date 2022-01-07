using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysCity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Proviceid { get; set; }
        public sbyte? Isvisible { get; set; }
    }
}
