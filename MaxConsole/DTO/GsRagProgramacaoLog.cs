using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagProgramacaoLog
    {
        public int ProglogId { get; set; }
        public int AssId { get; set; }
        public int? DesenId { get; set; }
        public int? FunId { get; set; }
        public int? DesenSit { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatfim { get; set; }
    }
}
