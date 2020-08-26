using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosArquivosLog
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public int EvtNum { get; set; }
        public string EvtarqNome { get; set; }
        public int EvtarqTipo { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
    }
}
