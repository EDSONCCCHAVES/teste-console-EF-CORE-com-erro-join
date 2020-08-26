using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagAtualizacao
    {
        public int AtuverId { get; set; }
        public int AssId { get; set; }
        public string AtuverFile { get; set; }
        public DateTime? AtuverData { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
