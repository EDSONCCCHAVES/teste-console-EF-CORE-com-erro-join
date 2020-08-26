using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPlanosContasNfeRag
    {
        public int PlcNfeId { get; set; }
        public int? AssId { get; set; }
        public int? PlnctsgrpId { get; set; }
        public int? PlnctssubgrpId { get; set; }
        public int? PlnctsctsId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
