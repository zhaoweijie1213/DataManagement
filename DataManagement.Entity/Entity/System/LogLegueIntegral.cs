using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class LogLegueIntegral
    {
        public int Id { get; set; }
        /// <summary>
        /// 大厅Id
        /// </summary>
        public int Appid { get; set; }
        /// <summary>
        /// 联盟ID
        /// </summary>
        public int LeagueId { get; set; }
        /// <summary>
        /// 战队ID
        /// </summary>
        public int TeamId { get; set; }
        /// <summary>
        /// 成员ID
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public int Operation { get; set; }
        /// <summary>
        /// 积分值
        /// </summary>
        public int Integral { get; set; }
        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime Updatetime { get; set; }
        /// <summary>
        /// 操作后分数
        /// </summary>
        public int SumIntegral { get; set; }
    }
}
