using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosEquipamentosTerceirosCcusto
    {
        public int EvteqtterccId { get; set; }
        public int AssId { get; set; }
        public int? EvteqtterId { get; set; }
        public int? CencusgrpId { get; set; }
        public decimal? EvteqtterccValor { get; set; }
        public decimal? EvteqtterccPercentual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
