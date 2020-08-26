using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOcorrenciaAtendimento
    {
        public int OcoateId { get; set; }
        public int AssId { get; set; }
        public string OcoateDes { get; set; }
        public int? OcoateObs { get; set; }
        public int? OcoateProv { get; set; }
        public string OcoateInfoprov { get; set; }
        public int? OcoatePadrao { get; set; }
        public int? OcoateSetor { get; set; }
        public int? OcoateOpcdiv { get; set; }
        public int? OcoateOpccom { get; set; }
        public int? OcoateOpcfin { get; set; }
        public int? OcoateOpcsup { get; set; }
        public int? OcoateOpcger { get; set; }
        public int? OcoateOpctec { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OcoateTipo { get; set; }
    }
}
