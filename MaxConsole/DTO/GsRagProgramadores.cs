using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagProgramadores
    {
        public int PrgId { get; set; }
        public int AssId { get; set; }
        public string PrgNome { get; set; }
        public int? PrgSit { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? FunId { get; set; }
        public int? TrsId { get; set; }

        public virtual GsFuncionarios GsFuncionarios { get; set; }
    }
}
