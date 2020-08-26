using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCondicoesPagto
    {
        public GsCondicoesPagto()
        {
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
        }

        public int ConpagId { get; set; }
        public int AssId { get; set; }
        public string ConpagDes { get; set; }
        public int? ConpagPar { get; set; }
        public int? ConpagTip { get; set; }
        public int? ConpagDiavct { get; set; }
        public double? ConpagPerc { get; set; }
        public int? ConpagRatauto { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int ConpagNfeconpagTipoId { get; set; }

        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
    }
}
