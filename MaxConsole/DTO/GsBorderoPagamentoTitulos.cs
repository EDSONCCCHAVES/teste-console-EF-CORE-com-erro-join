using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoPagamentoTitulos
    {
        public int BorpagtitId { get; set; }
        public int AssId { get; set; }
        public int? CppId { get; set; }
        public int? CpbId { get; set; }
        public int? BorpagId { get; set; }
        public decimal? BorpagtitValor { get; set; }
        public decimal? BorpagtitJuros { get; set; }
        public decimal? BorpagtitMulta { get; set; }
        public decimal? BorpagtitDesconto { get; set; }
        public decimal? BorpagtitTotal { get; set; }
        public string BorpagtitObs { get; set; }
        public DateTime? BorpagtitDatpag { get; set; }
        public int? ForpagId { get; set; }
        public DateTime? BorpagtitDatchq { get; set; }
        public int? BorpagtitNumchq { get; set; }
        public string BorpagtitInfo { get; set; }
        public int? BorpagtitOpe { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AgrsugpagId { get; set; }
        public decimal? BorpagtitOdespesas { get; set; }
        public string BorpagtitAgencia { get; set; }
        public string BorpagtitContacorrente { get; set; }
        public string BorpagtitOrigem { get; set; }
        public string BorpagtitEmitente { get; set; }
        public string BorpagtitCpfcnpj { get; set; }
        public int? BanId { get; set; }
    }
}
