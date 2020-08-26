using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNomeEvento
    {
        public int NomevtId { get; set; }
        public int AssId { get; set; }
        public string NomevtDes { get; set; }
        public int? UfeId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string LocalEvento { get; set; }
        public DateTime? PeriodoIni { get; set; }
        public DateTime? PeriodoFin { get; set; }
    }
}
