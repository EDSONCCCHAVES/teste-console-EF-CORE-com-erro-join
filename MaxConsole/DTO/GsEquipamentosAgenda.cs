using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosAgenda
    {
        public int EptageId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? EptaprId { get; set; }
        public DateTime? EptageDatini { get; set; }
        public DateTime? EptageDatfim { get; set; }
        public int? EptageQtd { get; set; }
        public int? OrcId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
