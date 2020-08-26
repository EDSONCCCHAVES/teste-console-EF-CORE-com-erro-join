using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosBv
    {
        public int EvtbvId { get; set; }
        public int EvtId { get; set; }
        public int AssId { get; set; }
        public int? CliforId { get; set; }
        public DateTime? EvtbvData { get; set; }
        public decimal? EvtbvValor { get; set; }
        public int? EvtbvAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CppId { get; set; }
        public int? OrcbvId { get; set; }
    }
}
