using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCerimonial
    {
        public int CerId { get; set; }
        public int? CerSit { get; set; }
        public int? AssId { get; set; }
        public DateTime? CerIdata { get; set; }
        public double? CerIhora { get; set; }
        public DateTime? CerRdata { get; set; }
        public double? CerRhora { get; set; }
        public string CerNvo { get; set; }
        public string CerNva { get; set; }
        public int? CerIgr { get; set; }
        public int? CerRec { get; set; }
        public string CerObs { get; set; }
        public int? SysDel { get; set; }
        public int? OrcId { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string CerObsRec { get; set; }
    }
}
