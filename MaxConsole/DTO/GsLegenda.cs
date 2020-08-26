using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLegenda
    {
        public int LegId { get; set; }
        public int? AssId { get; set; }
        public string LegDescricao { get; set; }
        public string LegCodigo { get; set; }
        public string LegCor { get; set; }
        public int? LegTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
