using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagFaqLog
    {
        public int RagfaqlogId { get; set; }
        public int AssId { get; set; }
        public int RagfaqId { get; set; }
        public int? RagfaqlogTipo { get; set; }
        public int? FunId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
