using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class MailServerLog
    {
        public int Id { get; set; }
        public int Appid { get; set; }
        /// <summary>
        /// 邮件类型，1：文本，2：图片
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Title { get; set; } = null!;
        /// <summary>
        /// 邮件详情
        /// </summary>
        public string Content { get; set; } = null!;
        /// <summary>
        /// 类型：1全服玩家邮件，2指定玩家邮件
        /// </summary>
        public int Sendtype { get; set; }
        /// <summary>
        /// 全服存0
        /// </summary>
        public string Uids { get; set; } = null!;
        /// <summary>
        /// 1:是2:否含有附件
        /// </summary>
        public int Hasitems { get; set; }
        /// <summary>
        /// 奖励内容
        /// </summary>
        public string Items { get; set; } = null!;
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 是1否0置顶
        /// </summary>
        public int Istop { get; set; }
        public DateTime Createtime { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Begintime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime Endtime { get; set; }
        /// <summary>
        /// 状态，-1：手动删除， 默认1：正常，2：过期
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Operatorer { get; set; } = null!;
    }
}
