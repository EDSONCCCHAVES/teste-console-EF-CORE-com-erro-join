using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsGruposMateriais
    {
        public int GrpmatId { get; set; }
        public int AssId { get; set; }
        public string GrpmatDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
    }
}
