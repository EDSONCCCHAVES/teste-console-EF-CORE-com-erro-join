using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOperadorasCartao
    {
        public int OpecadId { get; set; }
        public int AssId { get; set; }
        public string OpecadDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public double? TaxaDeb { get; set; }
        public double? TaxaCre { get; set; }
        public double? TaxaAdn { get; set; }
        public double? TaxaValorOperacao { get; set; }
        public double? TaxaPercentualIof { get; set; }
        public string RegraMesemmesMesdireto { get; set; }
        public DateTime? RegraData { get; set; }
        public int? CliforId { get; set; }
    }
}
