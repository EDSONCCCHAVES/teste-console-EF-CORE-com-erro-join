using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosComprasCancelamentos
    {
        public GsPedidosComprasCancelamentos()
        {
            GsCancelamentosPedidosCompras = new HashSet<GsCancelamentosPedidosCompras>();
        }

        public int Id { get; set; }
        public int AssId { get; set; }
        public string PccanDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual ICollection<GsCancelamentosPedidosCompras> GsCancelamentosPedidosCompras { get; set; }
    }
}
