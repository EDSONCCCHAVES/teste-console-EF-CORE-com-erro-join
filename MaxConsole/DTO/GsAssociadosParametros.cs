using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosParametros
    {
        public int AssparId { get; set; }
        public int AssId { get; set; }
        public string AssparName { get; set; }
        public string AssparValue { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? DatAtual { get; set; }
        public int? UseAtual { get; set; }
    }
}
