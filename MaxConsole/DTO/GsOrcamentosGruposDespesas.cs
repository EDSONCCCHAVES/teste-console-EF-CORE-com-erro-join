using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosGruposDespesas
    {
        public int GrpdespeveId { get; set; }
        public int AssId { get; set; }
        public string GrpdespeveDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
