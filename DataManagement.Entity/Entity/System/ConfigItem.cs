using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class ConfigItem
    {
        public int Id { get; set; }
        /// <summary>
        /// 道具id
        /// </summary>
        public int Itemid { get; set; }
        /// <summary>
        /// 道具名称
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// 品质
        /// </summary>
        public string Quality { get; set; } = null!;
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 人物等级限制
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// VIP等级限制
        /// </summary>
        public int VipLevel { get; set; }
        /// <summary>
        /// 可否赠送
        /// </summary>
        public int GiveAble { get; set; }
        /// <summary>
        /// 出售价格
        /// </summary>
        public int SellPrice { get; set; }
        /// <summary>
        /// 钻石估价
        /// </summary>
        public int DiamondPrice { get; set; }
        /// <summary>
        /// 使用获得道具
        /// </summary>
        public int UseItem { get; set; }
        /// <summary>
        /// 使用获得钻石
        /// </summary>
        public int UseDiamond { get; set; }
        /// <summary>
        /// 使用获得金币
        /// </summary>
        public int UseMoney { get; set; }
        /// <summary>
        /// 使用获得礼券
        /// </summary>
        public int UsePhone { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; } = null!;
        /// <summary>
        /// 图标
        /// </summary>
        public int Icon { get; set; }
        /// <summary>
        /// 可否合成
        /// </summary>
        public int IsMerge { get; set; }
        /// <summary>
        /// 排序优先级
        /// </summary>
        public int OrderPriority { get; set; }
        /// <summary>
        /// 可否装备
        /// </summary>
        public int CanEquip { get; set; }
        /// <summary>
        /// 是否唯一
        /// </summary>
        public int IsUnique { get; set; }
        /// <summary>
        /// 是否通用
        /// </summary>
        public int IsAllShow { get; set; }
        /// <summary>
        /// 商务可用
        /// </summary>
        public int Affairs { get; set; }
        /// <summary>
        /// 大厅id
        /// </summary>
        public int Appid { get; set; }
        /// <summary>
        /// 游戏id
        /// </summary>
        public int Gameid { get; set; }
        /// <summary>
        /// 是否显示（后台使用）
        /// </summary>
        public int Isshow { get; set; }
    }
}
