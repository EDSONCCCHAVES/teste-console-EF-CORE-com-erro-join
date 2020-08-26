using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalNfeAlerta
    {
        public int NfnfealertaId { get; set; }
        public int? AssId { get; set; }
        public int? NfId { get; set; }
        public int? NfeloteId { get; set; }
        public string NfnfealertaAlerta { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
