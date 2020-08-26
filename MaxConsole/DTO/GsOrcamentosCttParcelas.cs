using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosCttParcelas
    {
        public int OrcCttparId { get; set; }
        public int OrcId { get; set; }
        public int AssId { get; set; }
        public int? NfId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? OrcCttparFat { get; set; }
        public DateTime? OrcCttparCobini { get; set; }
        public DateTime? OrcCttparCobfim { get; set; }
        public DateTime? OrcCttparVencto { get; set; }
        public int NfsId { get; set; }
    }
}
