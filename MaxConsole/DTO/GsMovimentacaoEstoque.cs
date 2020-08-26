using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMovimentacaoEstoque
    {
        public int MovestId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? MovestNumped { get; set; }
        public DateTime? MovestDat { get; set; }
        public int? MovestSit { get; set; }
        public string MovestMot { get; set; }
        public DateTime? MovestDatcan { get; set; }
        public string MovestMotcan { get; set; }
        public int? MovestItens { get; set; }
        public int? MovestQtd { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? MovestUsecan { get; set; }
        public int? MovestTipmov { get; set; }
    }
}
