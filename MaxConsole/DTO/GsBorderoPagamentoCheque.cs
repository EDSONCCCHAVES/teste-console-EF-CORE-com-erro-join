using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoPagamentoCheque
    {
        public int BorpagchqId { get; set; }
        public int? AssId { get; set; }
        public int? BanId { get; set; }
        public int? ConbanId { get; set; }
        public string BorpagchqNumcheque { get; set; }
        public string BorpagchqAgencia { get; set; }
        public string BorpagchqContacorrente { get; set; }
        public DateTime? BorpagchqDatapagamento { get; set; }
        public DateTime? BorpagchqBompara { get; set; }
        public string BorpagchqOrigem { get; set; }
        public string BorpagchqEmitente { get; set; }
        public string BorpagchqCpfcnpj { get; set; }
        public double? BorpagchqValor { get; set; }
        public int? BorpagId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
