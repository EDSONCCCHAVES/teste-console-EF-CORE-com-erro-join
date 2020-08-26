using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssistenciaTecnicaItens
    {
        public int AssteciteId { get; set; }
        public int AsstecId { get; set; }
        public int AssId { get; set; }
        public int? EqtserId { get; set; }
        public string AssteciteObs { get; set; }
        public string AssteciteInfo { get; set; }
        public int? AssteciteControle { get; set; }
        public DateTime? AssteciteDatcon { get; set; }
        public int? AssteciteSituacao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AssteciteOperacao { get; set; }
        public int? CliforId { get; set; }
        public decimal? AssteciteValor { get; set; }
    }
}
