using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaTiposEstimativas
    {
        public int Id { get; set; }
        public string TesDesc { get; set; }
        public double? TesFator { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
