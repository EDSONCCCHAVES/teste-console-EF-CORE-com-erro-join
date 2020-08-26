using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosAgenda
    {
        public int EvtageId { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public DateTime? EvtageData { get; set; }
        public int? EvtageHora { get; set; }
        public int? EvtageMotivo { get; set; }
        public int? EvtageCobrar { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OrcageId { get; set; }
        public string EvtageObs { get; set; }
    }
}
