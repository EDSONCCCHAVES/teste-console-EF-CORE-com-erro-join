using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSystemLog
    {
        public int LogId { get; set; }
        public int AssId { get; set; }
        public int? UserId { get; set; }
        public string LogMod { get; set; }
        public string LogDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
