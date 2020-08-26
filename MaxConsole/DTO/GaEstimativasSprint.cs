using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaEstimativasSprint
    {
        public int Id { get; set; }
        public int TrpId { get; set; }
        public int SptId { get; set; }
        public int? EpsFazer { get; set; }
        public int? EpsProgresso { get; set; }
        public int? EpsPronto { get; set; }
        public int? EpsMelhorias { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
