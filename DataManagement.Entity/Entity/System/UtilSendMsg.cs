using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class UtilSendMsg
    {
        public long Id { get; set; }
        /// <summary>
        /// 唯一标识，为文本名字
        /// </summary>
        public string Sysno { get; set; } = null!;
        /// <summary>
        /// 发送短信内容
        /// </summary>
        public string Msg { get; set; } = null!;
        /// <summary>
        /// 发送状态
        /// </summary>
        public int State { get; set; }
        public DateTime Createtime { get; set; }
        public string Operatoruser { get; set; } = null!;
        /// <summary>
        /// 存放路径
        /// </summary>
        public string Path { get; set; } = null!;
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }
    }
}
