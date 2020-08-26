using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNotaFiscalServicoNfseLog
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public short Tipo { get; set; }
        public int NfsId { get; set; }
        public int ParcelaId { get; set; }
        public int SysDel { get; set; }
        public int SysUsucad { get; set; }
        public DateTime SysDatcad { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GtNotaFiscalServicoNfse Nfs { get; set; }
    }
}
