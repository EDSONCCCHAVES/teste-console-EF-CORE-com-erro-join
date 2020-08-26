using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosVeiculos
    {
        public int EvtvclId { get; set; }
        public int? AssId { get; set; }
        public int? EvtId { get; set; }
        public int? VclId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? EvtvclData { get; set; }
        public int? EvtvclHora { get; set; }
        public string EvtvclObs { get; set; }
    }
}
