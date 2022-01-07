using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysMenu20200513
    {
        public int Id { get; set; }
        public int Pageid { get; set; }
        /// <summary>
        /// 是否为菜单
        /// </summary>
        public int IsMenu { get; set; }
        /// <summary>
        /// 菜单id
        /// </summary>
        public int? ParentPageid { get; set; }
        /// <summary>
        /// 菜单名
        /// </summary>
        public string MenuName { get; set; } = null!;
        /// <summary>
        /// 菜单类型：1、数据后台，2、代理商后台
        /// </summary>
        public string? MenuType { get; set; }
        /// <summary>
        /// 是否为整合页面：0、否，1、是
        /// </summary>
        public int? IsMerge { get; set; }
        /// <summary>
        /// 页面地址
        /// </summary>
        public string? PageUrl { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// Table是表格里的按钮 Bar是框架外的按钮
        /// </summary>
        public string? FunctionEnLst { get; set; }
        public string? FunctionChLst { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
    }
}
