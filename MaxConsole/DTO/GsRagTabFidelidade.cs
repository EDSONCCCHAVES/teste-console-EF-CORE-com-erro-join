using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagTabFidelidade
    {
        public int TabfidId { get; set; }
        public int AssId { get; set; }
        public int? TabfidMeses { get; set; }
        public decimal? TabfidDesconto { get; set; }
        public decimal? TabfidValorCompra { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string TabfidSubproduto { get; set; }
    }
}
