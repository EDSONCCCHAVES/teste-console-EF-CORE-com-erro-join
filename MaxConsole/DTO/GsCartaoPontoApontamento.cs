using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCartaoPontoApontamento
    {
        public int CarponId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public DateTime? CarponData { get; set; }
        public int? CarponHor1 { get; set; }
        public int? CarponHor2 { get; set; }
        public int? CarponHor3 { get; set; }
        public int? CarponHor5 { get; set; }
        public int? CarponHor6 { get; set; }
        public int? CarponHor4 { get; set; }
        public string CarponObs { get; set; }
        public int? CarponOpe { get; set; }
        public DateTime? CarponDat1 { get; set; }
        public DateTime? CarponDat2 { get; set; }
        public DateTime? CarponDat3 { get; set; }
        public DateTime? CarponDat5 { get; set; }
        public DateTime? CarponDat6 { get; set; }
        public DateTime? CarponDat4 { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string CarponMaqHor1 { get; set; }
        public string CarponMaqHor2 { get; set; }
        public string CarponMaqHor3 { get; set; }
        public string CarponMaqHor4 { get; set; }
        public string CarponMaqHor5 { get; set; }
        public string CarponMaqHor6 { get; set; }
    }
}
