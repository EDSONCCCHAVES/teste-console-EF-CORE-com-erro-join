using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagFaqArquivo
    {
        public int RagfaqarqId { get; set; }
        public int? AssId { get; set; }
        public int? RagfaqId { get; set; }
        public string RagfaqarqNome { get; set; }
        public byte[] RagfaqarqArquivo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? RagfaqarqTamanho { get; set; }
    }
}
