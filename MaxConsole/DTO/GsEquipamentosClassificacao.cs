using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosClassificacao
    {
        public int ClaeptId { get; set; }
        public int AssId { get; set; }
        public string ClaeptDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
    }
}
