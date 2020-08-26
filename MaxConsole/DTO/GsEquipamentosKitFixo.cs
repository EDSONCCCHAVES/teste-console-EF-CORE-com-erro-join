using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosKitFixo
    {
        public int KitfixoId { get; set; }
        public int AssId { get; set; }
        public int EqtserId { get; set; }
        public int? KitfixoEqtserid { get; set; }
        public int? KitfixoAguardando { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
        public int? EptaprId { get; set; }
    }
}
