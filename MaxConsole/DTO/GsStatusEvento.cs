using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsStatusEvento
    {
        public int StsevtId { get; set; }
        public int AssId { get; set; }
        public string StsevtDes { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
