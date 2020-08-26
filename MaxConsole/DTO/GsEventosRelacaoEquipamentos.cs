using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosRelacaoEquipamentos
    {
        public int EvtreleptId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? EptaprId { get; set; }
        public int? EvtreleptQtd { get; set; }
        public string EvtreleptObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
