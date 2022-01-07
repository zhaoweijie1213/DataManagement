using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    /// <summary>
    /// 地区玩法
    /// </summary>
    public partial class ConfigPlacePlay
    {
        public int Id { get; set; }
        public int? Gameid { get; set; }
        public string? Title { get; set; }
        public int? Codeno { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
