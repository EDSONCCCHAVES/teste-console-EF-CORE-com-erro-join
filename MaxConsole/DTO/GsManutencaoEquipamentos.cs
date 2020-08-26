using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsManutencaoEquipamentos
    {
        public int ManequipId { get; set; }
        public int EptId { get; set; }
        public int AssId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ManequipPed { get; set; }
        public int? FunId { get; set; }
        public int? EvtId { get; set; }
        public string ManequipDesdef { get; set; }
        public int? ManequipSit { get; set; }
    }
}
