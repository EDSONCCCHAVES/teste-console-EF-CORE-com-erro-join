using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagTabPagamento
    {
        public int TabpagtoId { get; set; }
        public int AssId { get; set; }
        public string TabpagtoDes { get; set; }
        public int TabpagtoProduto { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
