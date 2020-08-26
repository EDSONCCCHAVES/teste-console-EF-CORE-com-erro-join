using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLogEmpresa
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public string Empresa { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public string Acao { get; set; }
    }
}
