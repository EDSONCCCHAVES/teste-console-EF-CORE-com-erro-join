using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosImagem
    {
        public int Id { get; set; }
        public int OrcId { get; set; }
        public int AssId { get; set; }
        public string Arquivo { get; set; }
        public double? Tamanho { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
