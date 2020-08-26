using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosFiliais
    {
        public int AssfilId { get; set; }
        public int AssId { get; set; }
        public int? AssMtzid { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
