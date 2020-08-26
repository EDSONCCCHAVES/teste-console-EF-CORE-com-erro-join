using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsDatacenterHistorico
    {
        public int CttNum { get; set; }
        public DateTime DataMedicao { get; set; }
        public double? EspacoUsado { get; set; }
        public DateTime? DataRegistro { get; set; }
        public int? TabhospId { get; set; }
        public decimal? ValorDatacenter { get; set; }
        public int? AssId { get; set; }
        public int? SysDel { get; set; }
    }
}
