using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCompromissosAgendados
    {
        public int CpmageId { get; set; }
        public int AssId { get; set; }
        public int? UseId { get; set; }
        public int? AteId { get; set; }
        public int? CliforId { get; set; }
        public DateTime? CpmageData { get; set; }
        public int? CpmageHora { get; set; }
        public string CpmageAss { get; set; }
        public string CpmageDes { get; set; }
        public int? CpmageSit { get; set; }
        public int? CpmageRot { get; set; }
        public string CpmageDdd { get; set; }
        public string CpmageTel { get; set; }
        public string CpmageContato { get; set; }
        public int? SysDel { get; set; }
        public string SysDatcad { get; set; }
        public int? CpmageTipo { get; set; }
        public DateTime? CpmageDataprg { get; set; }
    }
}
