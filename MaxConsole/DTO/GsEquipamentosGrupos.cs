using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosGrupos
    {
        public int GrpeqtId { get; set; }
        public int AssId { get; set; }
        public string GrpeqtDes { get; set; }
        public double? GrpeqtPersemanal { get; set; }
        public double? GrpeqtPermensal { get; set; }
        public double? GrpeqtPeranual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ImpId { get; set; }
    }
}
