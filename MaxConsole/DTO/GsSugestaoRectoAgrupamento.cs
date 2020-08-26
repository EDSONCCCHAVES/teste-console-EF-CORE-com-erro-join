using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSugestaoRectoAgrupamento
    {
        public int AgrsugrecId { get; set; }
        public int AssId { get; set; }
        public string AgrsugrecDes { get; set; }
        public int? AgrsugrecAtivo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
