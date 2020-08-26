using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosDespesas
    {
        public int EvtdespId { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public int? OrcdespId { get; set; }
        public int? CliforId { get; set; }
        public int? EvtdespQtd { get; set; }
        public int? EvtdespQtdcobrar { get; set; }
        public decimal? EvtdespValor { get; set; }
        public decimal? EvtdespTotal { get; set; }
        public decimal? EvtdespTotalcobrar { get; set; }
        public DateTime? EvtdespVenc { get; set; }
        public int? EvtdespAgr { get; set; }
        public int? CattitId { get; set; }
        public int? SubcattitId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? GrpdespeveId { get; set; }
        public int? SubgrpdespeveId { get; set; }
        public int? CppId { get; set; }
        public string EvtdespObs { get; set; }
        public int? CptId { get; set; }
        public int? AdievtId { get; set; }
        public int? ClatitId { get; set; }
    }
}
