using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameGameStartDetail
    {
        public long Id { get; set; }
        /// <summary>
        /// 第几局
        /// </summary>
        public int Gamenum { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Starttime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime Endtime { get; set; }
        /// <summary>
        /// 日志id
        /// </summary>
        public long Logid { get; set; }
    }
}
