using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLog
    {
        public int LogId { get; set; }
        public int AssId { get; set; }
        public int? UserId { get; set; }
        public int? LicregId { get; set; }
        public string LogForm { get; set; }
        public string LogMsg { get; set; }
        public string LogMacadress { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
