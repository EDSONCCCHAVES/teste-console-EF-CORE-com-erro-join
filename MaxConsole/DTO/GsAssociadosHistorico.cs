using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosHistorico
    {
        public int AsshistId { get; set; }
        public int AssId { get; set; }
        public int AssociadoId { get; set; }
        public DateTime? AsshistData { get; set; }
        public string AsshistObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
