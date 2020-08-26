using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaRecursos
    {
        public int Id { get; set; }
        public int? TrsId { get; set; }
        public string RcsDesc { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
