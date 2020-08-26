using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosComprasEquipamentos
    {
        public int PedcompeptId { get; set; }
        public int AssId { get; set; }
        public int? PedcompId { get; set; }
        public int? ReqcomiteId { get; set; }
        public string PedcompeptDes { get; set; }
        public string PedcompeptObs { get; set; }
        public string PedcompeptMarca { get; set; }
        public int? PedcompeptQtd { get; set; }
        public decimal? PedcompeptVal { get; set; }
        public decimal? PedcompeptTot { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? PedcompeptQtdcom { get; set; }
        public decimal? PedcompeptValcom { get; set; }
        public decimal? PedcompeptTotcom { get; set; }
    }
}
