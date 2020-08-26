using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsComissaovendas
    {
        public int ComvenId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public int? CrtId { get; set; }
        public int? CrpId { get; set; }
        public int? CppId { get; set; }
        public int? ComvenFunid { get; set; }
        public double? ComvenPor { get; set; }
        public double? ComvenValor { get; set; }
        public int? ComvenTipo { get; set; }
        public double? ComvenParcela { get; set; }
        public DateTime? ComvenDataini { get; set; }
        public DateTime? ComvenDatafim { get; set; }
        public int? ComvenCal { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
