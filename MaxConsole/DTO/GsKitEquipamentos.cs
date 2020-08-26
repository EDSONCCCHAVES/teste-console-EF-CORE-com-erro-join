using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsKitEquipamentos
    {
        public int CpskiteqtId { get; set; }
        public int AssId { get; set; }
        public int? CpskiteqtEptaprid { get; set; }
        public int? EptaprId { get; set; }
        public int? CpskiteqtQtd { get; set; }
        public int? EqtserId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
