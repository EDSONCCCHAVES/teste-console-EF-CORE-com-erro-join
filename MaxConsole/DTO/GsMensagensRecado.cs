using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMensagensRecado
    {
        public int MsgrecId { get; set; }
        public int AssId { get; set; }
        public int? MsgrecUseridRem { get; set; }
        public int? MsgrecUseridDes { get; set; }
        public int? MsgrecAssidRem { get; set; }
        public string MsgrecAssunto { get; set; }
        public string MsgrecMsg { get; set; }
        public DateTime? MsgrecDatlei { get; set; }
        public int? MsgrecStatus { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
