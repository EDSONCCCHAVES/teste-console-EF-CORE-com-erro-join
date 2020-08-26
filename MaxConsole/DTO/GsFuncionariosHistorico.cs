using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionariosHistorico
    {
        public int FunhistId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public DateTime? FunhistData { get; set; }
        public string FunhistObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
