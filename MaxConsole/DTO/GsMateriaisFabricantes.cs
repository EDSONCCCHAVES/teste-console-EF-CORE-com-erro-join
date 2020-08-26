using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMateriaisFabricantes
    {
        public int MatfabId { get; set; }
        public int AssId { get; set; }
        public string MatfabDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
    }
}
