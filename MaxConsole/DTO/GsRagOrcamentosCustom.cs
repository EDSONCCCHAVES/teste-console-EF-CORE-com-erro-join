using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagOrcamentosCustom
    {
        public int RagorccusId { get; set; }
        public int RagorcId { get; set; }
        public int AssId { get; set; }
        public string RagorccusModulo { get; set; }
        public string RagorccusModinfo { get; set; }
        public int? RagorccusGrau { get; set; }
        public int? RagorccusHoras { get; set; }
        public int? RagorccusValor { get; set; }
        public decimal? RagorccusTotal { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
