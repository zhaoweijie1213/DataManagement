using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysCounty
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Cityid { get; set; }
        public sbyte? Isvisible { get; set; }
    }
}
