using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosVeiculosMotoristas
    {
        public int EvtvclmotId { get; set; }
        public int? FunId { get; set; }
        public int? EvtvclId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? EvtvclmotData { get; set; }
        public int? EvtvclmotHora { get; set; }
        public string EvtvclmotObs { get; set; }
    }
}
