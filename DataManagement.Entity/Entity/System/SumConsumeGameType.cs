using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumConsumeGameType
    {
        public long Id { get; set; }
        public int? Provinceid { get; set; }
        public int? Cityid { get; set; }
        public int? Countyid { get; set; }
        public int? Gameid { get; set; }
        public int? Gametype { get; set; }
        public int? Roomtype { get; set; }
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
        public DateOnly? Date { get; set; }
    }
}
