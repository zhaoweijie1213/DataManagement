﻿using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysRoleBtn
    {
        public int Id { get; set; }
        public int Roleid { get; set; }
        public int Pageid { get; set; }
        public string? Name { get; set; }
    }
}