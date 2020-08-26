using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTransfDadosReajusteDatacenter
    {
        public int Id { get; set; }
        public int? CttNum { get; set; }
        public DateTime? DataMedicao { get; set; }
        public double? EspacoTabela { get; set; }
        public double? TotalMedicao { get; set; }
        public double? TotalDados { get; set; }
        public double? TotalFtp { get; set; }
        public double? TotalLog { get; set; }
        public decimal? ValorTabela { get; set; }
        public int? TabhospId { get; set; }
        public int? AssId { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public int? SysDel { get; set; }
    }
}
