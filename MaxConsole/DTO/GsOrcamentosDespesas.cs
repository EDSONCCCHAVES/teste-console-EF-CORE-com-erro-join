using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosDespesas
    {
        public int OrcdespId { get; set; }
        public int AssId { get; set; }
        public int OrcId { get; set; }
        public int? CliforId { get; set; }
        public int? OrcdespQtd { get; set; }
        public decimal? OrcdespValor { get; set; }
        public decimal? OrcdespTotal { get; set; }
        public DateTime? OrcdespVenc { get; set; }
        public int? OrcdespAgr { get; set; }
        public int? CattitId { get; set; }
        public int? SubcattitId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? GrpdespeveId { get; set; }
        public int? SubgrpdespeveId { get; set; }
        public string OrcdespObs { get; set; }
    }
}
