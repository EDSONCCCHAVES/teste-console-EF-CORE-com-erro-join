using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMovimentacaoCaixa
    {
        public int MovcaiId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? ConbanId { get; set; }
        public DateTime? MovcaiData { get; set; }
        public decimal? MovcaiValor { get; set; }
        public string MovcaiHist { get; set; }
        public int? MovcaiSit { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
