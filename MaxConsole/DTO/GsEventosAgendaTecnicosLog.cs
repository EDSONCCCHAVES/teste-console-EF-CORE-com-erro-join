using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosAgendaTecnicosLog
    {
        public int LogId { get; set; }
        public int? SysDel { get; set; }
        public int? AssId { get; set; }
        public int? FunId { get; set; }
        public int? LogTipo { get; set; }
        public int? EvtId { get; set; }
        public DateTime? LogDathor { get; set; }
        public string LogDes { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? UseId { get; set; }
    }
}
