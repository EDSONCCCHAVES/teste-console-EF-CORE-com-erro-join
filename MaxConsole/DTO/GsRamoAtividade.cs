using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRamoAtividade
    {
        public int RtvId { get; set; }
        public int AssId { get; set; }
        public string RtvNome { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
