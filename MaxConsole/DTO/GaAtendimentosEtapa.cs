using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaAtendimentosEtapa
    {
        public int Id { get; set; }
        public int? AteId { get; set; }
        public int? NirelId { get; set; }
        public int? EtapaFlag { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
