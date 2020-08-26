using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosEmpresasSetores
    {
        public GsAssociadosEmpresasSetores()
        {
            GsPlanocontasSetor = new HashSet<GsPlanocontasSetor>();
        }

        public int AssempsetId { get; set; }
        public int AssId { get; set; }
        public int EmpId { get; set; }
        public string AssempsetNome { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int AssempsetEtapa { get; set; }

        public virtual ICollection<GsPlanocontasSetor> GsPlanocontasSetor { get; set; }
    }
}
