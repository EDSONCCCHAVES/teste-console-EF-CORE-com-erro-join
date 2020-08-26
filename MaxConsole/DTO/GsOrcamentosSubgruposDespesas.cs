using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosSubgruposDespesas
    {
        public int SubgrpdespeveId { get; set; }
        public int AssId { get; set; }
        public int GrpdespeveId { get; set; }
        public string SubgrpdespeveDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
