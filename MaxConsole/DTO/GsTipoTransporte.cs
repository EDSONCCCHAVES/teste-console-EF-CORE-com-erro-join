using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTipoTransporte
    {
        public int TiptranspId { get; set; }
        public int AssId { get; set; }
        public string TiptranspDesc { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
