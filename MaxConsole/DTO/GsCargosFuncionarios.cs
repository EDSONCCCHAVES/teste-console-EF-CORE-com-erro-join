using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCargosFuncionarios
    {
        public int CarfunId { get; set; }
        public int AssId { get; set; }
        public string CarfunDes { get; set; }
        public int? CarfunPonto { get; set; }
        public int? CarfunHor1 { get; set; }
        public int? CarfunHor2 { get; set; }
        public int? CarfunHor3 { get; set; }
        public int? CarfunHor4 { get; set; }
        public int? CarfunHor5 { get; set; }
        public int? CarfunHor6 { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
