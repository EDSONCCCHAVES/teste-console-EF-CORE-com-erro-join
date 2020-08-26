using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosComprasSolicitacoes
    {
        public int PedcomsolId { get; set; }
        public int PedcomId { get; set; }
        public int AssId { get; set; }
        public int? ReqcomId { get; set; }
        public int? ReqcomQtd { get; set; }
        public decimal? ReqcomValor { get; set; }
        public decimal? ReqcomTotal { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ReqcomQtdcom { get; set; }
        public decimal? ReqcomValorcom { get; set; }
        public decimal? ReqcomTotalcom { get; set; }
        public int? ReqcomiteId { get; set; }
    }
}
