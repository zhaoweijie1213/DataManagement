using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysSmsConfig
    {
        public int Id { get; set; }
        /// <summary>
        /// 发送类型
        /// </summary>
        public string Type { get; set; } = null!;
        /// <summary>
        /// 模板Id
        /// </summary>
        public string Tempid { get; set; } = null!;
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Msg { get; set; } = null!;
    }
}
