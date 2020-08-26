using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosCancelamentos
    {
        public int OrccanId { get; set; }
        public int AssId { get; set; }
        public string OrccanDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
