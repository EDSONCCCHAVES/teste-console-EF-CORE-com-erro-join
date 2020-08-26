using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosKitfixoServicos
    {
        public int KitfixoservId { get; set; }
        public int AssId { get; set; }
        public int EqtserId { get; set; }
        public int? ServId { get; set; }
        public int? KitfixoservQtd { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
        public int? EptaprId { get; set; }
    }
}
