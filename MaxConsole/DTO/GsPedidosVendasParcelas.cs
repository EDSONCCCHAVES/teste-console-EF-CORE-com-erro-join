using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosVendasParcelas
    {
        public int PedvenparId { get; set; }
        public int AssId { get; set; }
        public int? PedvenId { get; set; }
        public int? PedvenparNum { get; set; }
        public decimal? PedvenparValor { get; set; }
        public int? PedvenparPrazo { get; set; }
        public DateTime? PedvenparVenc { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
