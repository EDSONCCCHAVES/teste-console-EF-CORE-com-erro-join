using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaTiposRecursosProjetos
    {
        public int Id { get; set; }
        public int TrsId { get; set; }
        public int PrjId { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public double? TrpValor { get; set; }
        public int? TrpQtd { get; set; }
    }
}
