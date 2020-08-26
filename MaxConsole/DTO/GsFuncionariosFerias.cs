using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionariosFerias
    {
        public int FunferId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public DateTime? FunferDatainicio { get; set; }
        public DateTime? FunferDatatermino { get; set; }
        public string FunferObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? FunferPerdaqsDttermino { get; set; }
        public DateTime? FunferPerdaqsDtinicio { get; set; }
    }
}
