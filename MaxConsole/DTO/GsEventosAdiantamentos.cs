using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosAdiantamentos
    {
        public int AdievtId { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public int? FunId { get; set; }
        public string AdievtDes { get; set; }
        public double? AdievtValor { get; set; }
        public int? AdievtAgr { get; set; }
        public DateTime? AdievtData { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CppId { get; set; }
        public string AdievtObs { get; set; }
    }
}
