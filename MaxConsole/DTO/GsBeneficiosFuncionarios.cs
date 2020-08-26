using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBeneficiosFuncionarios
    {
        public int BnffunId { get; set; }
        public int AssId { get; set; }
        public int BnfId { get; set; }
        public int? FunId { get; set; }
        public decimal? BnffunVal { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
