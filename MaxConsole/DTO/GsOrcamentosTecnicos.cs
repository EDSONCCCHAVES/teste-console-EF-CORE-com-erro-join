using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosTecnicos
    {
        public int OrctecId { get; set; }
        public int OrcId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? CarfunId { get; set; }
        public int? CargnivId { get; set; }
        public int? OrctecResp { get; set; }
        public DateTime? OrctecData { get; set; }
        public decimal? OrctecValneg { get; set; }
        public decimal? OrctecValdir { get; set; }
        public int? OrctecTipo { get; set; }
        public int? OrctecAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? OrctecVencimento { get; set; }
    }
}
