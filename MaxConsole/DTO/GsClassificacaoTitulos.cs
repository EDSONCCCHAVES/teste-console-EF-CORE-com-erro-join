using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsClassificacaoTitulos
    {
        public GsClassificacaoTitulos()
        {
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
        }

        public int ClatitId { get; set; }
        public int AssId { get; set; }
        public string ClatitDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }

        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
    }
}
