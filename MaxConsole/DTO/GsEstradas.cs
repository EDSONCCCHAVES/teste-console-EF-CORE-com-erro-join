using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEstradas
    {
        public int EstId { get; set; }
        public int AssId { get; set; }
        public string EstNome { get; set; }
        public int? EstTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
