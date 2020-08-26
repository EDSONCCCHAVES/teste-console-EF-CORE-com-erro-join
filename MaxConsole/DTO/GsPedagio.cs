using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedagio
    {
        public int PedaId { get; set; }
        public int AssId { get; set; }
        public int TraId { get; set; }
        public int? CidId { get; set; }
        public int? PedaTipo { get; set; }
        public double? PedaKm { get; set; }
        public decimal? PedaValor { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
