using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCfop
    {
        public GsCfop()
        {
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
        }

        public int CfopId { get; set; }
        public int AssId { get; set; }
        public int? Cfcod { get; set; }
        public string Cfnome { get; set; }
        public string Cfnota { get; set; }
        public int? CfopSys { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int GeraFinanceiro { get; set; }
        public int GeraEstoque { get; set; }
        public int MarcaDefault { get; set; }

        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
    }
}
