using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsScript
    {
        public int CmdtagId { get; set; }
        public int AssId { get; set; }
        public string CmdtagGs { get; set; }
        public int? CmdtagGrupo { get; set; }
        public string CmdtagDesc { get; set; }
        public string CmdtagScript { get; set; }
        public string CmdtagInfo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
