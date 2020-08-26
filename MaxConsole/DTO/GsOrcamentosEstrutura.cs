using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosEstrutura
    {
        public int OrcestId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public string OrcestNome { get; set; }
        public decimal? OrcestValor { get; set; }
        public string OrcestObs { get; set; }
        public DateTime? OrcestDatini { get; set; }
        public DateTime? OrcestDatter { get; set; }
        public int? OrcestNumpes { get; set; }
        public int? OrcestDias { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
