using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTabelaNcm
    {
        public int TabncmId { get; set; }
        public int? AssId { get; set; }
        public string TabncmCodigo { get; set; }
        public string TabncmDescricao { get; set; }
        public double? TabncmAliquota { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
