using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosCliente
    {
        public int EvecliId { get; set; }
        public int AssId { get; set; }
        public DateTime? EvecliDataini { get; set; }
        public DateTime? EvecliDatafim { get; set; }
        public string EvecliHora { get; set; }
        public string EvecliLocal { get; set; }
        public string EvecliTema { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
