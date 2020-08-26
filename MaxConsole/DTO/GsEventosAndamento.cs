using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosAndamento
    {
        public int EvtadtId { get; set; }
        public int StsevtId { get; set; }
        public DateTime? EvtadtData { get; set; }
        public int? AssId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? UseId { get; set; }
        public int? EvtId { get; set; }
        public string EvtadtObs { get; set; }
    }
}
