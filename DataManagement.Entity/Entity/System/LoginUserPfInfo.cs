using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class LoginUserPfInfo
    {
        public long Id { get; set; }
        public int Areaid { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public long Uid { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLogintime { get; set; }
        public string Pf { get; set; } = null!;
    }
}
