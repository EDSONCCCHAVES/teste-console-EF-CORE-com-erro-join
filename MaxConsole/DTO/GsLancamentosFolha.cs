using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLancamentosFolha
    {
        public int TablanId { get; set; }
        public int AssId { get; set; }
        public string TablanDes { get; set; }
        public int? TablanTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
