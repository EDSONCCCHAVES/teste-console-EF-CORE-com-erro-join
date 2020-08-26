using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAtendimentosAudio
    {
        public int AteaudioId { get; set; }
        public int AssId { get; set; }
        public int? AteId { get; set; }
        public string Arquivo { get; set; }
        public double? Tamanho { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
