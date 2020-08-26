using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsIgrejaRecepcao
    {
        public int IgrId { get; set; }
        public int? AssId { get; set; }
        public string IgrDes { get; set; }
        public int? IgrCid { get; set; }
        public string IgrEnd { get; set; }
        public string IgrUfe { get; set; }
        public string IgrCep { get; set; }
        public string IgrBai { get; set; }
        public string IgrComp { get; set; }
        public string IgrNum { get; set; }
        public int? IgrTip { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
