using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosEquipe
    {
        public int EvteqpId { get; set; }
        public int? AssId { get; set; }
        public int? EvtId { get; set; }
        public string EvteqpDescricao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
