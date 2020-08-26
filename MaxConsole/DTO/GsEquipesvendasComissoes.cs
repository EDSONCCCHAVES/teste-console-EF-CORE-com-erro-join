using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipesvendasComissoes
    {
        public int EqpId { get; set; }
        public int AssId { get; set; }
        public int FunId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EqpTipoorc { get; set; }
        public double? EqpApresentaPorc { get; set; }
        public double? EqpIndicacaoPorc { get; set; }
        public double? EqpFechamentoPorc { get; set; }
        public double? EqpCarteiraPorc { get; set; }
    }
}
