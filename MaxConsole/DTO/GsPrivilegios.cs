using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPrivilegios
    {
        public int UseprvId { get; set; }
        public string UseprvMod { get; set; }
        public string UseprvDes { get; set; }
        public int? UseprvGrp { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string UseprvObservacao { get; set; }
        public int? UserId { get; set; }
        public string LogForm { get; set; }
        public int? LicregId { get; set; }
        public string LogMacadress { get; set; }
    }
}
