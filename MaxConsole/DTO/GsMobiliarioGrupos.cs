using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMobiliarioGrupos
    {
        public int GrpmobId { get; set; }
        public int AssId { get; set; }
        public string GrpmobNome { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
