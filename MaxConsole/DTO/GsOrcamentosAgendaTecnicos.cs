using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosAgendaTecnicos
    {
        public int OrcagetecId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public int? CarfunId { get; set; }
        public int? CargnivId { get; set; }
        public DateTime? OrcagetecData { get; set; }
        public int? OrcagetecQtde { get; set; }
        public decimal? OrcagetecVlrdiaria { get; set; }
        public decimal? OrcagetecVlrcliente { get; set; }
        public int? OrcagetecAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? OrcagetecVencimento { get; set; }
        public int? OrcagetecTipoDiaria { get; set; }
    }
}
