using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCotasvendas
    {
        public int CotvenId { get; set; }
        public int AssId { get; set; }
        public string CotvenDes { get; set; }
        public double? CotvenPercmet { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CotvenNivel { get; set; }
        public int? CotvenTipoorc { get; set; }
        public double? CotvenMeta { get; set; }
        public int? CotvenAtivo { get; set; }
        public DateTime? CotvenDataini { get; set; }
        public DateTime? CotvenDatafim { get; set; }
        public int? CotvenEquipe { get; set; }
    }
}
