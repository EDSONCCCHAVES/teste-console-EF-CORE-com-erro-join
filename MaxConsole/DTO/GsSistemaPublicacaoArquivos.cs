using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSistemaPublicacaoArquivos
    {
        public int PubverId { get; set; }
        public int AssId { get; set; }
        public int? FilesystemId { get; set; }
        public string PubverFilename { get; set; }
        public string PubverFilepathinstall { get; set; }
        public int? PubverVersao1 { get; set; }
        public int? PubverVersao2 { get; set; }
        public int? PubverVersao3 { get; set; }
        public int? PubverVersao4 { get; set; }
        public int? PubverFilewidth { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? PubverSeguranca { get; set; }
        public int? PubverTipo { get; set; }
    }
}
