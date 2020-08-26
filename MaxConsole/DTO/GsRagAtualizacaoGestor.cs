using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagAtualizacaoGestor
    {
        public int AtgId { get; set; }
        public int AssId { get; set; }
        public string AtgNome { get; set; }
        public string AtgFtphost { get; set; }
        public string AtgFtpuser { get; set; }
        public string AtgFtppass { get; set; }
        public string AtgFtpdir { get; set; }
        public int? AtgAtivo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
