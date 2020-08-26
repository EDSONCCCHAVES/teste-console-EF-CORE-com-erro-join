using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosComprasCcusto
    {
        public int PedcompccId { get; set; }
        public int AssId { get; set; }
        public int? PedcompId { get; set; }
        public int? CencusgrpId { get; set; }
        public decimal? PedcompccValor { get; set; }
        public decimal? PedcompccPercentual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
