using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagTabProdutos
    {
        public int TabproId { get; set; }
        public int AssId { get; set; }
        public string TabproDescricao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
