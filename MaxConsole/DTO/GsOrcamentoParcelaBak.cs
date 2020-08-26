using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentoParcelaBak
    {
        public int OrcparId { get; set; }
        public int AssId { get; set; }
        public int OrcId { get; set; }
        public int? OrcparNum { get; set; }
        public decimal? OrcparValor { get; set; }
        public int? OrcparPrazo { get; set; }
        public DateTime? OrcparVecnto { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
