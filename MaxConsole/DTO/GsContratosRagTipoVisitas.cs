using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContratosRagTipoVisitas
    {
        public int CtttvId { get; set; }
        public int CtttvTipoId { get; set; }
        public string CtttvDescr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
