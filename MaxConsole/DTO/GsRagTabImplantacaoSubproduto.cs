using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagTabImplantacaoSubproduto
    {
        public int TabimpId { get; set; }
        public int AssId { get; set; }
        public int? TabimpEstacao { get; set; }
        public decimal? TabimpValorHosp { get; set; }
        public decimal? TabimpValorSuporte { get; set; }
        public string TabimpSubproduto { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? TabimpImplantacao { get; set; }
        public decimal? TabimpValor { get; set; }
    }
}
