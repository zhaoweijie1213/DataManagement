using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameGameRule
    {
        public int Id { get; set; }
        /// <summary>
        /// 游戏id
        /// </summary>
        public int? Gameid { get; set; }
        /// <summary>
        /// 规则名称
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 规则编号
        /// </summary>
        public int? Codeno { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Createtime { get; set; }
    }
}
