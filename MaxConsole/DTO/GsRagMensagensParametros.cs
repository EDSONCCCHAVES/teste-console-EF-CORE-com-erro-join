using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagMensagensParametros
    {
        public int PrmmsgId { get; set; }
        public int? MsgId { get; set; }
        public int? MsgDiasApos { get; set; }
        public int? PrmmsgSup { get; set; }
        public DateTime? SysDatalt { get; set; }
        public double? MsgMultas { get; set; }
        public double? MsgJuros { get; set; }
        public double? MsgBxBoleto { get; set; }
        public int? SysDel { get; set; }
    }
}
