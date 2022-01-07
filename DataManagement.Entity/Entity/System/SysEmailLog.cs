using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysEmailLog
    {
        public int Id { get; set; }
        public int? AppId { get; set; }
        public int? GameId { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? GameEditDate { get; set; }
        /// <summary>
        /// 系统时间
        /// </summary>
        public DateTime? SysDate { get; set; }
        public string? Key { get; set; }
        /// <summary>
        /// 更新内容
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 发布人
        /// </summary>
        public string? AddUser { get; set; }
        /// <summary>
        /// 操作人员
        /// </summary>
        public string? OperateUser { get; set; }
        /// <summary>
        /// 修改文件
        /// </summary>
        public string? EditFile { get; set; }
        /// <summary>
        /// 修改数据库
        /// </summary>
        public string? EditDb { get; set; }
        /// <summary>
        /// 游戏版本
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// 0、未更新，1、已更新，2、取消
        /// </summary>
        public int? State { get; set; }
        /// <summary>
        /// 操作结果
        /// </summary>
        public string? OperateResult { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 邮件标题
        /// </summary>
        public string? EmailTitle { get; set; }
        /// <summary>
        /// 邮件内容
        /// </summary>
        public string? EmailContent { get; set; }
        /// <summary>
        /// 收件人
        /// </summary>
        public string? EmailReceiveUser { get; set; }
        /// <summary>
        /// 发件人
        /// </summary>
        public string? EmailSendUser { get; set; }
        /// <summary>
        /// 发件人密码
        /// </summary>
        public string? EmailSendPwd { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string? Attachment { get; set; }
        /// <summary>
        /// 0、未发送，1、发送成功，2、发送失败
        /// </summary>
        public int? EmailState { get; set; }
    }
}
