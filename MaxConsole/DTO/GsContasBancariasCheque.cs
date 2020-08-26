using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasBancariasCheque
    {
        public int ConchqId { get; set; }
        public int ConbanId { get; set; }
        public int AssId { get; set; }
        public DateTime? ConchqData { get; set; }
        public int? ConchqNumini { get; set; }
        public int? ConchqNumfim { get; set; }
        public string ConchqResp { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
