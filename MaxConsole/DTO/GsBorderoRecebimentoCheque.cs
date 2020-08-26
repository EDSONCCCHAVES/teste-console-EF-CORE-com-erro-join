using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoRecebimentoCheque
    {
        public int BorrecchqId { get; set; }
        public int? AssId { get; set; }
        public int? BanId { get; set; }
        public int? ConbanId { get; set; }
        public string BorrecchqNumcheque { get; set; }
        public string BorrecchqAgencia { get; set; }
        public string BorrecchqContacorrente { get; set; }
        public DateTime? BorrecchqDatapagamento { get; set; }
        public DateTime? BorrecchqBompara { get; set; }
        public string BorrecchqOrigem { get; set; }
        public string BorrecchqEmitente { get; set; }
        public string BorrecchqCpfcnpj { get; set; }
        public double? BorrecchqValor { get; set; }
        public int? BorrecId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
