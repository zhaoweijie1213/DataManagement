using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysUser
    {
        public long Id { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        public string Account { get; set; } = null!;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// 英文编码
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string? Truename { get; set; }
        /// <summary>
        /// 性别，1男，2女
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? Createtime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
        public DateTime? Lastlogintime { get; set; }
        public long? Parentid { get; set; }
        public string? SysNo { get; set; }
        public string? ParentSysNo { get; set; }
        /// <summary>
        /// 英文编码
        /// </summary>
        public string? Ecode { get; set; }
    }
}
