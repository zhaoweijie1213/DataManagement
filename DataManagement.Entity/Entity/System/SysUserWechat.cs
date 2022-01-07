using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysUserWechat
    {
        public int Id { get; set; }
        public string Openid { get; set; } = null!;
        public int Userid { get; set; }
        public string Mobile { get; set; } = null!;
        public string? Nickname { get; set; }
        public DateTime Createtime { get; set; }
        public DateTime Updatetime { get; set; }
    }
}
