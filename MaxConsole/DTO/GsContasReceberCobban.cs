using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasReceberCobban
    {
        public int CobbanId { get; set; }
        public int AssId { get; set; }
        public int? CrpId { get; set; }
        public int? CobbanInst { get; set; }
        public string CobbanCart { get; set; }
        public int? CobbanSit { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
