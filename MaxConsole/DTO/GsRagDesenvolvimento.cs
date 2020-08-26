using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagDesenvolvimento
    {
        public int ModprgId { get; set; }
        public int AssId { get; set; }
        public int? PrgId { get; set; }
        public string ModprgNome { get; set; }
        public string ModprgDes { get; set; }
        public int? ModprgSit { get; set; }
        public DateTime? ModprgDatprvini { get; set; }
        public DateTime? ModprgDatprvter { get; set; }
        public DateTime? ModprgDatofcini { get; set; }
        public DateTime? ModprgDatofcter { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
