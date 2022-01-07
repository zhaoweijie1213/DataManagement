using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysRole
    {
        public int Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; } = null!;
        /// <summary>
        /// 注释
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 0为禁用 1为启用
        /// </summary>
        public int? State { get; set; }
    }
}
