using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosTabPreco
    {
        public int EqttabpreId { get; set; }
        public int AssId { get; set; }
        public int? EtqId { get; set; }
        public int? TabprcId { get; set; }
        public decimal? EqttabprePrecopadrao { get; set; }
        public decimal? EqttabprePrecominimo { get; set; }
        public decimal? EqttabprePrecosubloc { get; set; }
        public decimal? EqttabprePrecovenda { get; set; }
        public double? EqttabprePercent { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? Id26 { get; set; }
        public int? ImpId { get; set; }
    }
}
