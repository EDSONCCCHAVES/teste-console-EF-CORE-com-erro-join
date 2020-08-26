using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagControleDesenvolvimentoCom
    {
        public int DsvcomId { get; set; }
        public int DsvId { get; set; }
        public int AssId { get; set; }
        public int? DsvSit { get; set; }
        public string DsvcomInf { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
