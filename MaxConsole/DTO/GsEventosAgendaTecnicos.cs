using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosAgendaTecnicos
    {
        public int EvtagetecId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? CarfunId { get; set; }
        public int? CargnivId { get; set; }
        public DateTime? EvtagetecData { get; set; }
        public int? EvtagetecQtde { get; set; }
        public decimal? EvtagetecVlrdiaria { get; set; }
        public decimal? EvtagetecVlrcliente { get; set; }
        public int? EvtagetecAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OrcagetecId { get; set; }
        public DateTime? EvtagetecVencimento { get; set; }
        public int? EvtagetecTipoDiaria { get; set; }
        public double? EvtagetecTotalhoraexcedente { get; set; }
        public double? EvtagetecHoraexcedente { get; set; }
    }
}
