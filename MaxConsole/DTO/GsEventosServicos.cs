using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosServicos
    {
        public int EvtservId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? ServId { get; set; }
        public decimal? EvtservPreco { get; set; }
        public double? EvtservQtd { get; set; }
        public double? EvtservQtdcobrar { get; set; }
        public decimal? EvtservTotal { get; set; }
        public decimal? EvtservTotalcobrar { get; set; }
        public int? EvtservAgr { get; set; }
        public string EvtservObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? NfId { get; set; }
        public int? EvtservLancado { get; set; }
        public double? EvtservQtdLancado { get; set; }
        public int? OrcservId { get; set; }
        public DateTime? EvtservData { get; set; }
        public int? LegId { get; set; }
    }
}
