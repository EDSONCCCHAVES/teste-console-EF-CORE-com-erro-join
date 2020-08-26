using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagSubgruposFaq
    {
        public int RagsubgrpfaqId { get; set; }
        public int RaggrpfaqId { get; set; }
        public int AssId { get; set; }
        public string RagsubgrpfaqDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
