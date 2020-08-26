using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLogPolitica
    {
        public int Id { get; set; }
        public int? AssId { get; set; }
        public int? UsuId { get; set; }
        public string Usuario { get; set; }
        public string Cpu { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
        public DateTime? Data { get; set; }
        public string Licenca { get; set; }
    }
}
