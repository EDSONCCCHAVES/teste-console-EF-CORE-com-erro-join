using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagFaq
    {
        public int RagfaqId { get; set; }
        public int AssId { get; set; }
        public string RagfaqTitulo { get; set; }
        public string RagfaqDescr { get; set; }
        public string RagfaqHtml { get; set; }
        public int? RagfaqAcesso { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AssempsetId { get; set; }
        public int? RaggrpfaqId { get; set; }
        public int? RagsubgrpfaqId { get; set; }
    }
}
