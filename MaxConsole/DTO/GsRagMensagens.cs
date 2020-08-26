using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagMensagens
    {
        public int MsgId { get; set; }
        public string MsgNome { get; set; }
        public string MsgInfo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AssId { get; set; }
        public int? MsgDias { get; set; }
        public int? MsgDiasApos { get; set; }
        public int? MsgSelecao { get; set; }
        public int? MsgAviso { get; set; }
        public int? MsgBloqueio { get; set; }
        public int? MsgSobsel { get; set; }
        public string MsgDesclink { get; set; }
        public string MsgLink { get; set; }
    }
}
