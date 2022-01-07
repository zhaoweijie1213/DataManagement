using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SumGameStart
    {
        public long Id { get; set; }
        public int Provinceid { get; set; }
        public int Cityid { get; set; }
        public int Areaid { get; set; }
        public int Gameid { get; set; }
        /// <summary>
        /// 地方打法
        /// </summary>
        public int Placeplay { get; set; }
        /// <summary>
        /// 房间类型，3人房，4人房
        /// </summary>
        public int Roomtype { get; set; }
        /// <summary>
        /// 几局，（4局，8局）
        /// </summary>
        public int Gametype { get; set; }
        public DateOnly Date { get; set; }
        /// <summary>
        /// 总开局数
        /// </summary>
        public int Totalcount { get; set; }
        /// <summary>
        /// 总开局数
        /// </summary>
        public int Totalcount1 { get; set; }
        /// <summary>
        /// 总开局数
        /// </summary>
        public int Totalcount2 { get; set; }
        /// <summary>
        /// 总开局数
        /// </summary>
        public int Totalcount3 { get; set; }
        /// <summary>
        /// 正常开局数
        /// </summary>
        public int Normalcount { get; set; }
        /// <summary>
        /// 代开房局数
        /// </summary>
        public int Takecount { get; set; }
        public int Totalroomcardcount { get; set; }
        /// <summary>
        /// 房卡消耗量
        /// </summary>
        public int Roomcardcount { get; set; }
        /// <summary>
        /// 通用房卡消耗量
        /// </summary>
        public int Generalroomcardcount { get; set; }
        /// <summary>
        /// 钻石消耗数量
        /// </summary>
        public int Totaldiamondcount { get; set; }
        /// <summary>
        /// 钻石消耗数量
        /// </summary>
        public int Diamondcount { get; set; }
        /// <summary>
        /// 地区钻石消耗量
        /// </summary>
        public int Areadiamondcount { get; set; }
        /// <summary>
        /// 俱乐部局数
        /// </summary>
        public int Clubcount { get; set; }
        /// <summary>
        /// 俱乐部代开房
        /// </summary>
        public int Clubtakecount { get; set; }
        /// <summary>
        /// 正常的俱乐部开房
        /// </summary>
        public int Clubnormalcount { get; set; }
        public int Clubtotalroomcardcount { get; set; }
        /// <summary>
        /// 俱乐部房卡消耗量
        /// </summary>
        public int Clubroomcardcount { get; set; }
        /// <summary>
        /// 俱乐部通用房卡消耗量
        /// </summary>
        public int Clubgeneralroomcardcount { get; set; }
        public int Clubtotaldiamondcount { get; set; }
        /// <summary>
        /// 俱乐部钻石消耗量
        /// </summary>
        public int Clubdiamondcount { get; set; }
        /// <summary>
        /// 俱乐部地区钻石消耗量
        /// </summary>
        public int Clubareadiamondcount { get; set; }
    }
}
