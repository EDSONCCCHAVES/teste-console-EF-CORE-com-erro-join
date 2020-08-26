using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFornecedoresTipos
    {
        public int TipforId { get; set; }
        public int AssId { get; set; }
        public string TipforNome { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
