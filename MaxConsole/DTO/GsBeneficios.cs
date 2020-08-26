using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBeneficios
    {
        public int BnfId { get; set; }
        public int AssId { get; set; }
        public string BnfDes { get; set; }
        public decimal? BnfVal { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
