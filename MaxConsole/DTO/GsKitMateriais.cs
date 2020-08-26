using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsKitMateriais
    {
        public int CpskitmatId { get; set; }
        public int AssId { get; set; }
        public int? MatId { get; set; }
        public int? EptaprId { get; set; }
        public int? CpskitmatQtd { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
