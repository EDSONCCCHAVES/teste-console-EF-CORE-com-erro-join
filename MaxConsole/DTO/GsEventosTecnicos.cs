using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosTecnicos
    {
        public int EvttecId { get; set; }
        public int EvtId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? CarfunId { get; set; }
        public int? CargnivId { get; set; }
        public int? EvttecResp { get; set; }
        public DateTime? EvttecData { get; set; }
        public decimal? EvttecValneg { get; set; }
        public decimal? EvttecValdir { get; set; }
        public int? EvttecTipo { get; set; }
        public int? EvttecAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CppId { get; set; }
        public int? OrctecId { get; set; }
        public DateTime? EvttecVencimento { get; set; }
        public double? EvttecTotalhoraexcedente { get; set; }
        public int? EvttecQtde { get; set; }
        public double? EvttecHoraexcedente { get; set; }
    }
}
