using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagCobrancaNfe
    {
        public int CobnfeId { get; set; }
        public int? AssId { get; set; }
        public int? TabnfeId { get; set; }
        public int? CobnfeQtdeBase { get; set; }
        public double? CobnfeValorMensal { get; set; }
        public double? CobnfeValorNfeExtra { get; set; }
        public int? CobnfeQtdeNfeExtra { get; set; }
        public double? CobnfeValorExtraCobrado { get; set; }
        public double? CobnfeValorCobrado { get; set; }
        public string CobnfeCompetencia { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
