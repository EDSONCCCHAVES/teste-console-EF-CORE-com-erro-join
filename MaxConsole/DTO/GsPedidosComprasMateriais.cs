using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosComprasMateriais
    {
        public int PedcompitematId { get; set; }
        public int AssId { get; set; }
        public int? PedcompId { get; set; }
        public int? ReqcomiteId { get; set; }
        public int? PedcompitematQtd { get; set; }
        public decimal? PedcompitematPreco { get; set; }
        public decimal? PedcompitematTotal { get; set; }
        public int? PedcompitematQtdcom { get; set; }
        public decimal? PedcompitematTotalcom { get; set; }
        public decimal? PedcompitematPrecocom { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
