using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaEstimativasProjetos
    {
        public int Id { get; set; }
        public int TrpId { get; set; }
        public int? EprFazer { get; set; }
        public int? EprProgresso { get; set; }
        public int? EprPronto { get; set; }
        public int? EprMelhorias { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
