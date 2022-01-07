using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    /// <summary>
    /// 游戏日志表
    /// 说明：记录游戏开局信息，其中包含游戏开局基本信息，此表用于原型图（游戏开局，根据gameid统计APP和小游戏）统计
    /// </summary>
    public partial class GameGameStartLog
    {
        public long Id { get; set; }
        /// <summary>
        /// 服务器id
        /// </summary>
        public int Serverid { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
        public int Provinceid { get; set; }
        /// <summary>
        /// 地市级ID
        /// </summary>
        public int Cityid { get; set; }
        /// <summary>
        /// 区域ID
        /// </summary>
        public int Areaid { get; set; }
        /// <summary>
        /// 小游戏id
        /// </summary>
        public int Gameid { get; set; }
        /// <summary>
        /// 地方打法
        /// </summary>
        public int Placeplay { get; set; }
        /// <summary>
        /// 房间类型（几人）
        /// </summary>
        public int Roomtype { get; set; }
        /// <summary>
        /// 游戏类型（4局，8局）
        /// </summary>
        public int Gametype { get; set; }
        /// <summary>
        /// 游戏局流水号
        /// </summary>
        public string Gameno { get; set; } = null!;
        /// <summary>
        /// 房间号
        /// </summary>
        public string Roomkey { get; set; } = null!;
        /// <summary>
        /// 房主ID
        /// </summary>
        public long Roomuid { get; set; }
        /// <summary>
        /// 开房人uid
        /// </summary>
        public long Createuid { get; set; }
        /// <summary>
        /// 是否代开房
        /// </summary>
        public ulong Istake { get; set; }
        /// <summary>
        /// 俱乐部ID
        /// </summary>
        public int Clubid { get; set; }
        /// <summary>
        /// 是否消耗俱乐部房卡
        /// </summary>
        public int Costclubcard { get; set; }
        /// <summary>
        /// 游戏开始时间
        /// </summary>
        public DateTime Starttime { get; set; }
        /// <summary>
        /// 游戏结束时间
        /// </summary>
        public DateTime Endtime { get; set; }
        /// <summary>
        /// 游戏开局数
        /// </summary>
        public int Begininnings { get; set; }
        /// <summary>
        /// 游戏完成了的局数
        /// </summary>
        public int Endinnings { get; set; }
        /// <summary>
        /// 开局状态
        /// </summary>
        public int Matchstate { get; set; }
        /// <summary>
        /// 代开房uid
        /// </summary>
        public long Takeuid { get; set; }
        /// <summary>
        /// 代开房名称
        /// </summary>
        public string Takename { get; set; } = null!;
    }
}
