using System;
using System.Collections.Generic;

namespace DataManagement.Entity.Entity.System
{
    public partial class MailItemDrawLog
    {
        public long Id { get; set; }
        public int Appid { get; set; }
        public long Uid { get; set; }
        public int Mailid { get; set; }
        public int Gold { get; set; }
        public int Diamond { get; set; }
        public int Ticket { get; set; }
        public int Itemid { get; set; }
        public int Num { get; set; }
        public DateTime Createtime { get; set; }
        public int Receive { get; set; }
    }
}
