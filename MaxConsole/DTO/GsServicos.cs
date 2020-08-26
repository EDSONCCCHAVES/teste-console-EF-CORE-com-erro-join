using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsServicos
    {
        public int ServId { get; set; }
        public int AssId { get; set; }
        public string ServCod { get; set; }
        public string ServDes { get; set; }
        public string ServInfo { get; set; }
        public decimal? ServVal { get; set; }
        public int? UnidId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CencusgrpId { get; set; }
        public int? ImpId { get; set; }
        public double ServValOutrasRetencoes { get; set; }
        public double ServValDescCondicionado { get; set; }
        public double ServValDescIncondicionado { get; set; }
        public int? FamId { get; set; }
    }
}
