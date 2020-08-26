using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAgentesPagamento
    {
        public int AgepagId { get; set; }
        public int AssId { get; set; }
        public string AgepagDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public double? TaxaDeb { get; set; }
        public double? TaxaCre { get; set; }
        public double? TaxaAdn { get; set; }
        public double? TaxaValorOperacao { get; set; }
        public double? TaxaPercentualIof { get; set; }
    }
}
