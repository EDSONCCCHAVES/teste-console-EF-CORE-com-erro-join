using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosMateriais
    {
        public int EvtmatId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? MatId { get; set; }
        public decimal? EvtmatPreco { get; set; }
        public int? EvtmatQtd { get; set; }
        public int? EvtmatQtdcobrar { get; set; }
        public decimal? EvtmatTotal { get; set; }
        public decimal? EvtmatTotalcobrar { get; set; }
        public int? EvtmatAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EvtmatQtdretorno { get; set; }
        public int? NfId { get; set; }
        public string LogUsuario { get; set; }
        public DateTime? LogData { get; set; }
        public int? EvtmatLancado { get; set; }
        public int? EvtmatQtdLancado { get; set; }
    }
}
