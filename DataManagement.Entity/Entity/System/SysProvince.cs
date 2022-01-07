using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysProvince
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public sbyte? Isvisible { get; set; }
        public string? Pf { get; set; }
        public int? Areaid { get; set; }
    }
}
