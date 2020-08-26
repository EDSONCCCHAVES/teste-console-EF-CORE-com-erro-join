using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfeErro
    {
        public int NfeerroId { get; set; }
        public int? AssId { get; set; }
        public int? NfeloteId { get; set; }
        public string NfeerroErro { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
