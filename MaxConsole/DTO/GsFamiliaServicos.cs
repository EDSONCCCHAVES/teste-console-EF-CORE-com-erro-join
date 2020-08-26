using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFamiliaServicos
    {
        public int FamId { get; set; }
        public int AssId { get; set; }
        public string FamiliaDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
