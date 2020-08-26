using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosRelacaoMateriais
    {
        public int EvtrelmatId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? MatId { get; set; }
        public int? EvtrelmatQtd { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public short? EvtrelmatAgr { get; set; }
    }
}
