using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAdiantamentosItensCcusto
    {
        public int CpccId { get; set; }
        public int AssId { get; set; }
        public int? AdiId { get; set; }
        public int? CencusgrpId { get; set; }
        public decimal? CpccValor { get; set; }
        public double? CpccPercentual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AdiiteId { get; set; }
    }
}
