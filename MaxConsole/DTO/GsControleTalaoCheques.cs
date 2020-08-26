using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsControleTalaoCheques
    {
        public int ContalchqId { get; set; }
        public int AssId { get; set; }
        public int? ConbanId { get; set; }
        public DateTime? ContalchqData { get; set; }
        public int? ContalchqSit { get; set; }
        public int? ContalchqNumini { get; set; }
        public int? ContalchqNumfim { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
