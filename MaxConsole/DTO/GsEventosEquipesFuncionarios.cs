using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosEquipesFuncionarios
    {
        public int EvteqpfunId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? EvtId { get; set; }
        public int? EvteqpId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public double? EvteqpfunPercentual { get; set; }
        public decimal? EvteqpfunTotal { get; set; }
    }
}
