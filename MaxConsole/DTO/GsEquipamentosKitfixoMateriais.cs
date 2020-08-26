using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosKitfixoMateriais
    {
        public int KitfixomatId { get; set; }
        public int AssId { get; set; }
        public int MatId { get; set; }
        public int? EqtserId { get; set; }
        public int? KitfixomatQtd { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
        public int? EptaprId { get; set; }
    }
}
