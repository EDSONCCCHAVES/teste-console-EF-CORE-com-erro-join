using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalDescricaoGeral
    {
        public int NfdesgeId { get; set; }
        public int AssId { get; set; }
        public string NfdesgeDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
