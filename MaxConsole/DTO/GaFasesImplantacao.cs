using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaFasesImplantacao
    {
        public GaFasesImplantacao()
        {
            GsNivelRelacao = new HashSet<GsNivelRelacao>();
        }

        public int Id { get; set; }
        public string FsiDesc { get; set; }
        public int? FsiDias { get; set; }
        public string FsiObs { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }

        public virtual ICollection<GsNivelRelacao> GsNivelRelacao { get; set; }
    }
}
