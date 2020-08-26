using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssistenciaTecnicaLaudo
    {
        public int AssteclauId { get; set; }
        public int AssteciteId { get; set; }
        public int AssId { get; set; }
        public string AssteclauOcorrencia { get; set; }
        public int? AssteclauSituacao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? UseId { get; set; }
    }
}
