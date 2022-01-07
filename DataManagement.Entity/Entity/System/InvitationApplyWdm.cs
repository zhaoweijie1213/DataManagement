using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class InvitationApplyWdm
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 玩家id
        /// </summary>
        public int Playerid { get; set; }
        /// <summary>
        /// 申请id
        /// </summary>
        public int Applyid { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public int Source { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Itemtype { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Itemcount { get; set; }
        /// <summary>
        /// 申请结果 1同意 2拒绝
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Createtime { get; set; }
        /// <summary>
        /// 审批人
        /// </summary>
        public string? Approver { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public DateTime? Approvtime { get; set; }
        /// <summary>
        /// 区域id
        /// </summary>
        public int Areaid { get; set; }
        /// <summary>
        /// 当前邀请人数
        /// </summary>
        public int Curplayernum { get; set; }
        /// <summary>
        /// 需要邀请人数
        /// </summary>
        public int Needpalyernum { get; set; }
        /// <summary>
        /// 当前观看总广告次数
        /// </summary>
        public int Curtotalmovienum { get; set; }
        /// <summary>
        /// 需要观看总广告次数
        /// </summary>
        public int Needtotalmovienum { get; set; }
        /// <summary>
        /// 当前平均观看广告次数
        /// </summary>
        public int Curaveragemovie { get; set; }
        /// <summary>
        /// 需要平均观看广告次数
        /// </summary>
        public int Needaveragemovie { get; set; }
        /// <summary>
        /// 消耗人数
        /// </summary>
        public int Usedpalyernum { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string? Phone { get; set; }
    }
}
