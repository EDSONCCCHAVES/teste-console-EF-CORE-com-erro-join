using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagFaqPrivilegiosSubgrupos
    {
        public int RagprivsubgrpId { get; set; }
        public int? AssId { get; set; }
        public int? RagsubgrpfaqId { get; set; }
        public int? UseId { get; set; }
        public int? RagprivsubgrpVisualizar { get; set; }
        public int? RagprivsubgrpAlterar { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
