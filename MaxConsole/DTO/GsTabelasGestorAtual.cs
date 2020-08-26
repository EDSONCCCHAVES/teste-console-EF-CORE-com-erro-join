using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTabelasGestorAtual
    {
        public int TabId { get; set; }
        public int AssId { get; set; }
        public string TabName { get; set; }
        public int? TabValue { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
