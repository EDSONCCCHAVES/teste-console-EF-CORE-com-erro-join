using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCancelamentosPedidosCompras
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int PccanId { get; set; }
        public int PedcompId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GsPedidosComprasCancelamentos Pccan { get; set; }
    }
}
