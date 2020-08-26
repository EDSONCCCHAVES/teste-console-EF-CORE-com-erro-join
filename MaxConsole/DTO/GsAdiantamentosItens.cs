using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAdiantamentosItens
    {
        public int AdiiteId { get; set; }
        public int AssId { get; set; }
        public int? AdiId { get; set; }
        public int? CattitId { get; set; }
        public int? SubcattitId { get; set; }
        public string AdiiteHist { get; set; }
        public decimal? AdiiteValor { get; set; }
        public DateTime? AdiiteData { get; set; }
        public string AdiiteNum { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CliforId { get; set; }
    }
}
