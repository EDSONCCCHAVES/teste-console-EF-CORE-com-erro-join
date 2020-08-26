using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosDespesasCcusto
    {
        public int EvtdespccId { get; set; }
        public int AssId { get; set; }
        public int? EvtdespId { get; set; }
        public int? CencusgrpId { get; set; }
        public decimal? EvtdespccValor { get; set; }
        public double? EvtdespccPercentual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
