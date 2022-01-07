using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameNewUserLogCity
    {
        public long Id { get; set; }
        public long Uid { get; set; }
        public string Username { get; set; } = null!;
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public DateTime Createtime { get; set; }
    }
}
