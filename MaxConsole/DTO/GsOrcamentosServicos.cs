using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosServicos
    {
        public int OrcservId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public int? ServId { get; set; }
        public decimal? OrcservPreco { get; set; }
        public double? OrcservQtd { get; set; }
        public decimal? OrcservTotal { get; set; }
        public int? OrcservAgr { get; set; }
        public string OrcservObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? NfId { get; set; }
        public int? OrcservLancados { get; set; }
        public double? OrcservQtdLancados { get; set; }
        public int? OrcestiteId { get; set; }
        public int OrcservDias { get; set; }
    }
}
