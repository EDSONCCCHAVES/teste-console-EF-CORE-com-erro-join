using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosConsumo
    {
        public int EvtcsmId { get; set; }
        public int AssId { get; set; }
        public int? EptaprId { get; set; }
        public int? EvtId { get; set; }
        public double? EvtcsmQtd { get; set; }
        public int? UnidId { get; set; }
        public decimal? EvtcsmValor { get; set; }
        public decimal? EvtcsmTotal { get; set; }
        public string EvtcsmObs { get; set; }
        public DateTime? EvtcsmData { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? MatId { get; set; }
        public int EptId { get; set; }
    }
}
