using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSugestaoPagtoAgrupamento
    {
        public int AgrsugpagId { get; set; }
        public int AssId { get; set; }
        public string AgrsugpagDes { get; set; }
        public int? AgrsugpagAtivo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
