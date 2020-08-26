using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsUnidadeMedida
    {
        public int UnidId { get; set; }
        public int AssId { get; set; }
        public string UnidDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
    }
}
