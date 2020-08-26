using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsVersoesAlteracoes
    {
        public int VeraltId { get; set; }
        public int AssId { get; set; }
        public int UseId { get; set; }
        public string VeraltDes { get; set; }
        public int VeraltVer1 { get; set; }
        public int VeraltVer2 { get; set; }
        public int VeraltVer3 { get; set; }
        public int VeraltVer4 { get; set; }
        public string VeraltScript { get; set; }
        public int VeraltGerar { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int? VeraltUseDel { get; set; }
        public DateTime? VeraltDatDel { get; set; }
    }
}
