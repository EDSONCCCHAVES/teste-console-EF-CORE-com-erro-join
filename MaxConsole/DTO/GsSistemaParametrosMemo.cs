using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSistemaParametrosMemo
    {
        public int ParsismemoId { get; set; }
        public int AssId { get; set; }
        public string ParsismemoMod { get; set; }
        public string ParsismemoVal { get; set; }
        public string ParsismemoInfo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
