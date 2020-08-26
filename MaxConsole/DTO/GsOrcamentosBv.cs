using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosBv
    {
        public int OrcbvId { get; set; }
        public int OrcId { get; set; }
        public int AssId { get; set; }
        public int? CliforId { get; set; }
        public DateTime? OrcbvData { get; set; }
        public decimal? OrcbvValor { get; set; }
        public int? OrcbvAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OrcbvBase { get; set; }
        public decimal? OrcbvPercentual { get; set; }
        public int OrcbvTipoCalculo { get; set; }
    }
}
