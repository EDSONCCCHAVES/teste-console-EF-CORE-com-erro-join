using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipesvendas
    {
        public int EqpId { get; set; }
        public int AssId { get; set; }
        public string EqpDes { get; set; }
        public int? FunId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? FunId1 { get; set; }
        public int? FunId2 { get; set; }
        public double? EqpPorgergeral { get; set; }
        public double? EqpPorgerregio { get; set; }
        public double? EqpPorgervenda { get; set; }
        public int? EqpTipoorc { get; set; }
        public double? EqpApresentaPorc { get; set; }
        public double? EqpIndicacaoPorc { get; set; }
        public double? EqpFechamentoPorc { get; set; }
        public double? EqpCarteiraPorc { get; set; }
        public int? EqpTipo { get; set; }
        public int? EmpId { get; set; }
    }
}
