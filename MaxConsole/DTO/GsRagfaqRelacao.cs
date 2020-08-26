using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagfaqRelacao
    {
        public int RagfaqrelId { get; set; }
        public int AssId { get; set; }
        public int? RagfaqId1 { get; set; }
        public int? RagfaqId2 { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
