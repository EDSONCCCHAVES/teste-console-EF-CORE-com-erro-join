using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMovimentacaoEstoqueItens
    {
        public int MovestiteId { get; set; }
        public int MovestId { get; set; }
        public int? AssId { get; set; }
        public int? MatId { get; set; }
        public int? MovestiteQtd { get; set; }
        public int? MovestiteQtdret { get; set; }
        public int? MovestiteQtddev { get; set; }
        public DateTime? MovestiteDatret { get; set; }
        public DateTime? MovestiteDatdev { get; set; }
        public int? MovestiteSit { get; set; }
        public string MovestiteInfdev { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? MovestiteMatdestId { get; set; }
    }
}
