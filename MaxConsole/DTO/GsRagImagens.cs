using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagImagens
    {
        public int RagimgId { get; set; }
        public int AssId { get; set; }
        public string RagimgNome { get; set; }
        public string RagimgArq { get; set; }
        public int? RagimgTam { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
