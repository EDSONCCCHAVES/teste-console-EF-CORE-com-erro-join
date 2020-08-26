using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipesvendasFuncionarios
    {
        public int EqpfunId { get; set; }
        public int AssId { get; set; }
        public int FunId { get; set; }
        public int? EqpId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EqpTipo { get; set; }
        public double? EqpfunFechamento { get; set; }
        public double? EqpfunCarteira { get; set; }
    }
}
