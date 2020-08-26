using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaSetoresImplantacao
    {
        public GaSetoresImplantacao()
        {
            GsNivelRelacao = new HashSet<GsNivelRelacao>();
        }

        public int Id { get; set; }
        public string StiDesc { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }

        public virtual ICollection<GsNivelRelacao> GsNivelRelacao { get; set; }
    }
}
