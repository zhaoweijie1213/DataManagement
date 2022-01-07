using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class ConfigGameSource
    {
        public int Id { get; set; }
        public int Appid { get; set; }
        /// <summary>
        /// 1：app大厅，2：h5大厅
        /// </summary>
        public int Type { get; set; }
    }
}
