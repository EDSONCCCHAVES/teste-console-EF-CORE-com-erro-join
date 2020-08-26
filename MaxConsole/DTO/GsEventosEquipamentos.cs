using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosEquipamentos
    {
        public int EvteqtId { get; set; }
        public int EvtId { get; set; }
        public int? EqtId { get; set; }
        public int? AssId { get; set; }
        public decimal? EvteqtPreco { get; set; }
        public int? EvteqtQtd { get; set; }
        public int? EvteqtQtdcobrar { get; set; }
        public decimal? EvteqtTotal { get; set; }
        public decimal? EvteqtTotalcobrar { get; set; }
        public int? EvteqtAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EvteqtEqtterc { get; set; }
        public decimal? EvteqtPrecosubloc { get; set; }
        public int? NfId { get; set; }
        public int? EvteqtLancado { get; set; }
        public int? EvteqtQtdLancado { get; set; }
    }
}
