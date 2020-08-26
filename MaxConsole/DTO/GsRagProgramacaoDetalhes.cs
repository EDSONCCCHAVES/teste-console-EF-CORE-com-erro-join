using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagProgramacaoDetalhes
    {
        public int ProgdetId { get; set; }
        public int AssId { get; set; }
        public int? DesenId { get; set; }
        public int? FunId { get; set; }
        public string ProgdetDescricao { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
