using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContratosEquipamentos
    {
        public int CtteptId { get; set; }
        public int CttId { get; set; }
        public int AssId { get; set; }
        public int? EptaprId { get; set; }
        public int? CtteptQtd { get; set; }
        public decimal? CtteptValunt { get; set; }
        public decimal? CtteptValtot { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
