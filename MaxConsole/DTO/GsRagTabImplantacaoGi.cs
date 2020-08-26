using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagTabImplantacaoGi
    {
        public int TabimpId { get; set; }
        public int AssId { get; set; }
        public int? TabimpEstacao { get; set; }
        public int? TabimpImplantacao { get; set; }
        public decimal? TabimpValor { get; set; }
        public decimal? TabimpManutencao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public decimal? TabimpValorHosp { get; set; }
        public decimal? TabimpValorSuporte { get; set; }
    }
}
