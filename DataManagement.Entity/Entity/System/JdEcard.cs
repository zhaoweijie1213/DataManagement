using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class JdEcard
    {
        public long Id { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string Cardid { get; set; } = null!;
        /// <summary>
        /// E卡密码
        /// </summary>
        public string Cardpass { get; set; } = null!;
        /// <summary>
        /// 面额
        /// </summary>
        public int Money { get; set; }
        /// <summary>
        /// 有效时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Usetime { get; set; }
        /// <summary>
        /// 使用状态:未使用0已使用1
        /// </summary>
        public int State { get; set; }
    }
}
