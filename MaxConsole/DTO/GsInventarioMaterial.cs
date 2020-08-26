using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsInventarioMaterial
    {
        public int IvtmatId { get; set; }
        public int AssId { get; set; }
        public int? IvtmatNum { get; set; }
        public int? IvtmatSit { get; set; }
        public DateTime? IvtmatDatini { get; set; }
        public DateTime? IvtmatDatfim { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? FunId { get; set; }
    }
}
