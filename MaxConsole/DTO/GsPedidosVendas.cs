using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosVendas
    {
        public int PedvenId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public int? CliforId { get; set; }
        public int? ConpagId { get; set; }
        public int? PedvenNum { get; set; }
        public DateTime? PedvenDataprov { get; set; }
        public int? PedvenSit { get; set; }
        public int? PedvenQtde { get; set; }
        public double? PedvenValor { get; set; }
        public string PedvenObs { get; set; }
        public string PedvenPednum { get; set; }
        public string PedvenCondpag { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? PedVenStatus { get; set; }
        public int? PedvenEvento { get; set; }
    }
}
