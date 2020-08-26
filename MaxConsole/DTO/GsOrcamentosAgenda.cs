using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosAgenda
    {
        public int OrcageId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public DateTime? OrcageData { get; set; }
        public int? OrcageHora { get; set; }
        public int? OrcageMotivo { get; set; }
        public int? OrcageCobrar { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
