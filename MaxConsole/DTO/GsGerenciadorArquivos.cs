using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsGerenciadorArquivos
    {
        public int GerarqId { get; set; }
        public int AssId { get; set; }
        public int UserId { get; set; }
        public string GerarqFile { get; set; }
        public string GerarqDes { get; set; }
        public string GerarqPath { get; set; }
        public int? GerarqTipo { get; set; }
        public int? GerarqControle { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
