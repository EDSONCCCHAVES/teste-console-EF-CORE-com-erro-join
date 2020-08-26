using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosPrivilegios
    {
        public int AssprvId { get; set; }
        public int AssId { get; set; }
        public string AssprvMod { get; set; }
        public string AssprvDes { get; set; }
        public int? AssprvSit { get; set; }
        public int? AssprvGrp { get; set; }
        public int? AssprvIte { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
