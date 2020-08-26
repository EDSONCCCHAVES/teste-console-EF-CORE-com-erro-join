using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsInventarioMaterialItens
    {
        public int IvtmatiteId { get; set; }
        public int AssId { get; set; }
        public int? IvtmatId { get; set; }
        public int? MatId { get; set; }
        public int? IvtmatiteQtdivt { get; set; }
        public int? IvtmatiteQtdatu { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
