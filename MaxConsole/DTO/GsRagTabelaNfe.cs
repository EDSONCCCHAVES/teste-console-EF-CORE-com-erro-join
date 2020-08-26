using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagTabelaNfe
    {
        public int TabnfeId { get; set; }
        public int? AssId { get; set; }
        public string TabnfeDescricao { get; set; }
        public int? TabnfeQtdeBase { get; set; }
        public double? TabnfeValorMensal { get; set; }
        public double? TabnfeValorNfeExtra { get; set; }
        public double? TabnfeValorSetup { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
