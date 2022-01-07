using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysMerge
    {
        public int Id { get; set; }
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int? PageId { get; set; }
        /// <summary>
        /// 整合的页面
        /// </summary>
        public string? MergedPageIds { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }
    }
}
