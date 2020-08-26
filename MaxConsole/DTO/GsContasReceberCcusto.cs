using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasReceberCcusto
    {
        public int CrccId { get; set; }
        public int AssId { get; set; }
        public int? CrpId { get; set; }
        public int? CencusgrpId { get; set; }
        public decimal? CrccValor { get; set; }
        public double? CrccPercentual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
