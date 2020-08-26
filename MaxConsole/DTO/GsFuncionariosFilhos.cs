using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionariosFilhos
    {
        public int FunfilId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public string FunfilNome { get; set; }
        public DateTime? FunfilDatnas { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
