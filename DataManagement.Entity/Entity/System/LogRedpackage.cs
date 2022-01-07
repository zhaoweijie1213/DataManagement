using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class LogRedpackage
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 内部订单号/商户订单号
        /// </summary>
        public string? OrderId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public long? Uid { get; set; }
        /// <summary>
        /// 区域id
        /// </summary>
        public int? Areaid { get; set; }
        public string? Pf { get; set; }
        /// <summary>
        /// 微信openid
        /// </summary>
        public string? OpenId { get; set; }
        /// <summary>
        /// 微信商户号
        /// </summary>
        public string? MchId { get; set; }
        /// <summary>
        /// 商户appid
        /// </summary>
        public string? MchAppId { get; set; }
        /// <summary>
        /// api业务执行结果
        /// </summary>
        public string? ResultCode { get; set; }
        /// <summary>
        /// 错误代码
        /// </summary>
        public string? ErrCode { get; set; }
        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string? ErrCodeDes { get; set; }
        /// <summary>
        /// 微信订单号
        /// </summary>
        public string? PaymentNo { get; set; }
        /// <summary>
        /// 微信支付成功时间
        /// </summary>
        public DateTime? PaymentTime { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public string? ProductId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int? State { get; set; }
        /// <summary>
        /// 订单创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 消耗的兑换券
        /// </summary>
        public int? CostTicket { get; set; }
    }
}
