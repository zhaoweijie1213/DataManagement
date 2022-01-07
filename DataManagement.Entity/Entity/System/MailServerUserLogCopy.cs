using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class MailServerUserLogCopy
    {
        public long Id { get; set; }
        public int Appid { get; set; }
        public long Uid { get; set; }
        /// <summary>
        /// 邮件编号
        /// </summary>
        public int Mailid { get; set; }
        /// <summary>
        /// 阅读状态
        /// </summary>
        public int Isread { get; set; }
        /// <summary>
        /// 1：是，0：否领取
        /// </summary>
        public int Isdraw { get; set; }
        /// <summary>
        /// 邮件状态，1：正常，-1：删除
        /// </summary>
        public int State { get; set; }
        public DateTime? Readtime { get; set; }
        public DateTime? Drawtime { get; set; }
    }
}
