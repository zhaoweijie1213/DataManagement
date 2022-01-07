using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class LogJuheOrder
    {
        public long Id { get; set; }
        public long Uid { get; set; }
        /// <summary>
        /// 代理商编号，为空时是玩家充值
        /// </summary>
        public string Agentsysno { get; set; } = null!;
        public int Areaid { get; set; }
        /// <summary>
        /// 充值的手机号
        /// </summary>
        public string Tel { get; set; } = null!;
        /// <summary>
        /// 消耗的兑换券
        /// </summary>
        public int Costticket { get; set; }
        /// <summary>
        /// 商品类型，商品类型，1：礼品卡，2：话费直充，3：影视会员直充
        /// </summary>
        public int ProductType { get; set; }
        /// <summary>
        /// 商品id，当type2时，为第三方返回的cardid
        /// </summary>
        public string ProductId { get; set; } = null!;
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; } = null!;
        /// <summary>
        /// 聚合订单号
        /// </summary>
        public string JuheOrderId { get; set; } = null!;
        /// <summary>
        /// 自己的订单号，（新第三方）订单规则：第一位为提卡还是直充C/T,第二位为配置表的product_type,剩下的为时间及随机数
        /// </summary>
        public string UserOrderId { get; set; } = null!;
        /// <summary>
        /// 本次发货数量
        /// </summary>
        public int Num { get; set; }
        /// <summary>
        /// 充值金额，type为2时代表充值话费金额（元）
        /// </summary>
        public decimal Rechargenum { get; set; }
        /// <summary>
        /// 最终扣费总额
        /// </summary>
        public decimal Ordercash { get; set; }
        /// <summary>
        /// 加密后的卡号，type1时的字段
        /// </summary>
        public string CardNo { get; set; } = null!;
        /// <summary>
        /// 加密后的卡密，type1时的字段
        /// </summary>
        public string CardPws { get; set; } = null!;
        /// <summary>
        /// 失效时间，type1时的字段
        /// </summary>
        public string ExpireDate { get; set; } = null!;
        /// <summary>
        /// 聚合返回结果
        /// </summary>
        public string JuheReason { get; set; } = null!;
        /// <summary>
        /// 聚合返回的error_code
        /// </summary>
        public int JuheCode { get; set; }
        public DateTime Createtime { get; set; }
        /// <summary>
        /// 状态：0失败，1成功（这里只是内部状态，只要第三方返回成功了就算成功，如果有回调则为订单状态 2 是成功 3 是失败 9 是未确认）
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 短信发放结果
        /// </summary>
        public string SmsResult { get; set; } = null!;
        /// <summary>
        /// 来源，目前只有兑换：1
        /// </summary>
        public int Source { get; set; }
    }
}
