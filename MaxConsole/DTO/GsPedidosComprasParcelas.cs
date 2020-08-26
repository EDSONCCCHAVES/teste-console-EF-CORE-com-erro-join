using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosComprasParcelas
    {
        public int PedcompparcId { get; set; }
        public int AssId { get; set; }
        public int PedcompId { get; set; }
        public int? PedcompparcNum { get; set; }
        public decimal? PedcompparcValor { get; set; }
        public DateTime? PedcompparcVencto { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
