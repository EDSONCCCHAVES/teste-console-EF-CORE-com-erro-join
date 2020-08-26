using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRelatorios
    {
        public int RelId { get; set; }
        public int? AssId { get; set; }
        public string RelNome { get; set; }
        public int? RelGrpid { get; set; }
        public int? RelSubgrpid { get; set; }
        public int? RelMargsup { get; set; }
        public int? RelMarginf { get; set; }
        public int? RelMargesq { get; set; }
        public int? RelMargdir { get; set; }
        public int? RelTipopag { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
