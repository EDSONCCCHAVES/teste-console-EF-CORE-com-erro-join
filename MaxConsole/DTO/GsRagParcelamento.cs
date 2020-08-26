using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagParcelamento
    {
        public int PctId { get; set; }
        public int? AssId { get; set; }
        public string PctDes { get; set; }
        public int? PctDiaVcto { get; set; }
        public int? PctParcelas { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? SysDatalt { get; set; }
    }
}
