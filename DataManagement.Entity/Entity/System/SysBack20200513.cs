using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysBack20200513
    {
        public int Id { get; set; }
        /// <summary>
        /// 后台名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 状态：0、禁用，1、启用
        /// </summary>
        public int? State { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }
    }
}
