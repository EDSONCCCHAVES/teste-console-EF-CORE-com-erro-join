using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNotaFiscalServicoParcela
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int NfsId { get; set; }
        public int? NfsparNum { get; set; }
        public decimal? NfsparValor { get; set; }
        public int? NfsparPrazo { get; set; }
        public DateTime? NfsparVecnto { get; set; }
        public int SysDel { get; set; }
        public int SysUsucad { get; set; }
        public DateTime SysDatcad { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GtNotaFiscalServicoNfse Nfs { get; set; }
    }
}
