using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsClientesFornecedoresObs
    {
        public int CliforobsId { get; set; }
        public int AssId { get; set; }
        public int? CliforId { get; set; }
        public DateTime? CliforobsData { get; set; }
        public string CliforobsObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
