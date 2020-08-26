using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosAdiantamentos
    {
        public int AdiorcId { get; set; }
        public int AssId { get; set; }
        public int OrcId { get; set; }
        public int? FunId { get; set; }
        public string AdiorcDes { get; set; }
        public double? AdiorcValor { get; set; }
        public int? AdiorcAgr { get; set; }
        public DateTime? AdiorcData { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string AdiorcObs { get; set; }
    }
}
