using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsControleCheque
    {
        public int ConchqId { get; set; }
        public int AssId { get; set; }
        public int? ConbanId { get; set; }
        public int? CliforId { get; set; }
        public int? ConchqNum { get; set; }
        public DateTime? ConchqDataemi { get; set; }
        public DateTime? ConchqDatpag { get; set; }
        public string ConchqInfo { get; set; }
        public DateTime? ConchqDatcomp { get; set; }
        public int? ConchqSit { get; set; }
        public DateTime? ConchqConbandat { get; set; }
        public int? ConchqConbansit { get; set; }
        public double? ConchqValor { get; set; }
        public string ConchqHist { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
