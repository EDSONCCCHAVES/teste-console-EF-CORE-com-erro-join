using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCondicoesPagtoParcelas
    {
        public int ConpagparId { get; set; }
        public int AssId { get; set; }
        public int ConpagId { get; set; }
        public int? ConpagparDia { get; set; }
        public double? ConpagparPerc { get; set; }
        public int? ConpagparJuros { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
