using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosParcela
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
        public int? PlnctssubgrpId { get; set; }
        public int? PlnctsgrpId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public int? PlnctsctsId { get; set; }
        public int? GrptitId { get; set; }
        public int? SubgrpId { get; set; }
    }
}
