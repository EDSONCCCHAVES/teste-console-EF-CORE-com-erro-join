using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPrestacaoContasItens
    {
        public int PresconiteId { get; set; }
        public int AssId { get; set; }
        public int? PresconId { get; set; }
        public string PresconiteHist { get; set; }
        public decimal? PresconiteValor { get; set; }
        public DateTime? PresconiteData { get; set; }
        public string PresconiteNumrec { get; set; }
        public int? CattitId { get; set; }
        public int? SubcattitId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
