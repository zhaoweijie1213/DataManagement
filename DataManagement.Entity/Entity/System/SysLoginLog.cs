using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysLoginLog
    {
        public int Id { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int Userid { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string? Ip { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? Logintime { get; set; }
        /// <summary>
        /// 登陆来源，0：账号登陆，1：手机登录，2：微信登录
        /// </summary>
        public int? Source { get; set; }
        /// <summary>
        /// 登录的内容
        /// </summary>
        public string? Description { get; set; }
    }
}
