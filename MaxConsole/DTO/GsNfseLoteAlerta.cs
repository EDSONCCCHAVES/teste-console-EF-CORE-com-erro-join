using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfseLoteAlerta
    {
        public int NfselotealertaId { get; set; }
        public int AssId { get; set; }
        public int? NfseloteId { get; set; }
        public int? NfselotealertaCodigo { get; set; }
        public string NfselotealertaDescricao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
