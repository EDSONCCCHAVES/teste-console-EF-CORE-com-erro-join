using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagDriverImpressora
    {
        public int DrvimpId { get; set; }
        public int AssId { get; set; }
        public string DrvimpNome { get; set; }
        public int? DrvimpNor { get; set; }
        public int? DrvimpRed { get; set; }
        public int? DrvimpExp { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
