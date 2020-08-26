using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSuporteTecnicoMsg
    {
        public int SuptecmsgId { get; set; }
        public int AssId { get; set; }
        public string SuptecmsgAssunto { get; set; }
        public string SuptecmsgNome { get; set; }
        public string SuptecmsgMsg { get; set; }
        public int? SuptecmsgStatus { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
