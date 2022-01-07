using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysBusinessUserRelation
    {
        public int Id { get; set; }
        public string Parentsysno { get; set; } = null!;
        public string Businessmobile { get; set; } = null!;
        public int Parentid { get; set; }
    }
}
