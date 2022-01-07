using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class ConfigGame
    {
        public int Id { get; set; }
        public int Gameid { get; set; }
        /// <summary>
        /// 大厅编号
        /// </summary>
        public int? ParentCodeNo { get; set; }
        public string Title { get; set; } = null!;
        /// <summary>
        /// PF
        /// </summary>
        public string? ContainsCode { get; set; }
        public DateTime Createtime { get; set; }
        public int State { get; set; }
        /// <summary>
        /// 0是不通用 1是通用 通用适用于所有地区
        /// </summary>
        public int? Iscommon { get; set; }
        /// <summary>
        /// 是否开启三级分销
        /// </summary>
        public int? IsOpenDistribution { get; set; }
        /// <summary>
        /// 自动审核
        /// </summary>
        public int? IsAutoAudit { get; set; }
        /// <summary>
        /// 激活最小金额
        /// </summary>
        public decimal? ActivationMinPrice { get; set; }
        /// <summary>
        /// 激活最大金额
        /// </summary>
        public decimal? ActivationMaxPrice { get; set; }
        /// <summary>
        /// 限购金额
        /// </summary>
        public decimal? LimitMaxPrice { get; set; }
        /// <summary>
        /// 充值最小金额
        /// </summary>
        public decimal? RechargeMinPrice { get; set; }
        /// <summary>
        /// 充值最大金额
        /// </summary>
        public decimal RechargeMaxPrice { get; set; }
        /// <summary>
        /// 商务专员微信
        /// </summary>
        public string? BusinessWeChat { get; set; }
        /// <summary>
        /// 开通通用游戏
        /// </summary>
        public string? OpenGameIds { get; set; }
        /// <summary>
        /// 一级代理返利
        /// </summary>
        public decimal? RebateProportion1 { get; set; }
        /// <summary>
        /// 二级代理返利
        /// </summary>
        public decimal? RebateProportion2 { get; set; }
        /// <summary>
        /// 不推荐代理返利
        /// </summary>
        public decimal? RebateProportion { get; set; }
        public string? Levelssysno { get; set; }
        /// <summary>
        /// 可用代理等级
        /// </summary>
        public string? Levelstitle { get; set; }
        /// <summary>
        /// 默认代理等级
        /// </summary>
        public string? DefaultLevel { get; set; }
        /// <summary>
        /// 默认代理等级是否分享
        /// </summary>
        public int? IsShare { get; set; }
        /// <summary>
        /// LOGO
        /// </summary>
        public string? LogUrl { get; set; }
        /// <summary>
        /// 二维码
        /// </summary>
        public string? DownLoadQrcodeUrl { get; set; }
        /// <summary>
        /// 产品图片
        /// </summary>
        public string? ProductPicture { get; set; }
    }
}
