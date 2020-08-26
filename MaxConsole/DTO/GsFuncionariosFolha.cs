using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionariosFolha
    {
        public int FunfolhaId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? VerbfolId { get; set; }
        public int? FunfolhaMes { get; set; }
        public int? FunfolhaAno { get; set; }
        public decimal? FunfolhaValor { get; set; }
        public DateTime? FunfolhaData { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
