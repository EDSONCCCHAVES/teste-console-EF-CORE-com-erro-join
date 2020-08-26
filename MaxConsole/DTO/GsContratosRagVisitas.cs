using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContratosRagVisitas
    {
        public int CttvId { get; set; }
        public int? CttvCttId { get; set; }
        public int? CttvAssId { get; set; }
        public DateTime CttvDataVisita { get; set; }
        public int CttvTipoVisita { get; set; }
        public int CttvConsultorId { get; set; }
        public TimeSpan? CttvHoraIni { get; set; }
        public TimeSpan? CttvHoraFim { get; set; }
        public string CttvLoginUsuarioNome { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }

        public virtual GsContratosRag Cttv { get; set; }
    }
}
