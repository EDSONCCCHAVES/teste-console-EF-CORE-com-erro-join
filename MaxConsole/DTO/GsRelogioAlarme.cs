using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRelogioAlarme
    {
        public int RelalrId { get; set; }
        public int AssId { get; set; }
        public int UseId { get; set; }
        public string RelalrDes { get; set; }
        public int RelalrTip { get; set; }
        public int RelalrData { get; set; }
        public int RelalrDia { get; set; }
        public int RelalrHora { get; set; }
        public int RelalrMinuto { get; set; }
        public int RelalrSegundo { get; set; }
        public int RelalrSit { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
    }
}
