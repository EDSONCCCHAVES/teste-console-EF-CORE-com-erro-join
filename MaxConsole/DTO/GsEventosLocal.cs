using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosLocal
    {
        public int EvtlocId { get; set; }
        public int AssId { get; set; }
        public string EvtlocLocal { get; set; }
        public string EvtlocEnd { get; set; }
        public string EvtlocNum { get; set; }
        public string EvtlocCpl { get; set; }
        public string EvtlocCep { get; set; }
        public string EvtlocBai { get; set; }
        public int? CidId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string EvtlocTel1 { get; set; }
        public string EvtlocDdd1 { get; set; }
        public string EvtlocObs { get; set; }
        public string EvtlocCon { get; set; }
    }
}
