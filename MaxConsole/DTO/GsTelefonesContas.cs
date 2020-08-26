using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTelefonesContas
    {
        public int ContelId { get; set; }
        public int CadtelId { get; set; }
        public int AssId { get; set; }
        public string ContelDes { get; set; }
        public int? ContelMes { get; set; }
        public int? ContelAno { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
