using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTelefonesContasRegistro
    {
        public int TelconregId { get; set; }
        public int ContelId { get; set; }
        public int AssId { get; set; }
        public DateTime? TelconregData { get; set; }
        public string TelconregTel { get; set; }
        public decimal? TelconregValor { get; set; }
        public int? TelconregTipo { get; set; }
        public int? CliforId { get; set; }
        public int? FunId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
