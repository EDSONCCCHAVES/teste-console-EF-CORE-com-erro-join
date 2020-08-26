using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMensagem
    {
        public int MsgId { get; set; }
        public DateTime? MsgData { get; set; }
        public string MsgTexto { get; set; }
    }
}
