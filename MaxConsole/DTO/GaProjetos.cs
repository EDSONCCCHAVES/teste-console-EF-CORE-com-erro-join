using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaProjetos
    {
        public int Id { get; set; }
        public int TesId { get; set; }
        public int? TprId { get; set; }
        public string PrjNome { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
