using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfseAtividade
    {
        public GsNfseAtividade()
        {
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
        }

        public int NfseatId { get; set; }
        public int AssId { get; set; }
        public string NfseatCodigo { get; set; }
        public string NfseatDescricao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }

        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
    }
}
