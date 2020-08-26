using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsDistribuidores
    {
        public int DisId { get; set; }
        public int AssId { get; set; }
        public string DisNome { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
