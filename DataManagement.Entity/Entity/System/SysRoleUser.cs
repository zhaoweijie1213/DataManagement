﻿using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class SysRoleUser
    {
        public int Id { get; set; }
        public int? Roleid { get; set; }
        public int? Userid { get; set; }
    }
}