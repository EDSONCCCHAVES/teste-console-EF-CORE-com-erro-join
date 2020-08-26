using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagParcelamentoItens
    {
        public int PciId { get; set; }
        public int? PciPar { get; set; }
        public int? AssId { get; set; }
        public int? PctId { get; set; }
        public int? PciJuros { get; set; }
        public int? PciMultas { get; set; }
        public int? PciPrazo { get; set; }
        public decimal? PciCobranca { get; set; }
        public int? SysDel { get; set; }
    }
}
