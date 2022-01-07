using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class GameConsumeLog
    {
        public long Id { get; set; }
        /// <summary>
        /// 游戏流水号
        /// </summary>
        public string Gameno { get; set; } = null!;
        /// <summary>
        /// 游戏区域
        /// </summary>
        public int Gameid { get; set; }
        public int? Areatype { get; set; }
        /// <summary>
        /// 游戏县级
        /// </summary>
        public int? Gametype { get; set; }
        /// <summary>
        /// 几人房
        /// </summary>
        public int? Roomtype { get; set; }
        public string? Roomkey { get; set; }
        public DateTime? Date { get; set; }
        public int? Clubid { get; set; }
        public int? Costclubcard { get; set; }
        public long? Costuid { get; set; }
        public int? Provinceid { get; set; }
        public int? Cityid { get; set; }
        public int? Countyid { get; set; }
        public int? Diamond { get; set; }
        /// <summary>
        /// 地区钻石
        /// </summary>
        public int? Areadiamond { get; set; }
        public int? Cardcount { get; set; }
        /// <summary>
        /// 通用房卡数量
        /// </summary>
        public int? Gecardcount { get; set; }
    }
}
