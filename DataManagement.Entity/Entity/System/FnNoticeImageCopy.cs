using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class FnNoticeImageCopy
    {
        public int Id { get; set; }
        /// <summary>
        /// 类型，1大厅图片
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 大厅id
        /// </summary>
        public int Appid { get; set; }
        /// <summary>
        /// 游戏id或者地区id
        /// </summary>
        public int Gameid { get; set; }
        /// <summary>
        /// 大厅
        /// </summary>
        public string Pf { get; set; } = null!;
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string Imgsrc { get; set; } = null!;
        /// <summary>
        /// 图片排序
        /// </summary>
        public int? Imagesort { get; set; }
        /// <summary>
        /// 动作编号
        /// </summary>
        public int Activetype { get; set; }
        /// <summary>
        /// 跳转链接
        /// </summary>
        public string Url { get; set; } = null!;
        /// <summary>
        /// 内容描述
        /// </summary>
        public string Content { get; set; } = null!;
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createtime { get; set; }
    }
}
