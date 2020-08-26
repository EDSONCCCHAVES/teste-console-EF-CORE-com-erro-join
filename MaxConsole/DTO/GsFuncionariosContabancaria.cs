using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionariosContabancaria
    {
        public int ConbanfunId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? BanId { get; set; }
        public int? ConbanfunTipo { get; set; }
        public string ConbanfunAge { get; set; }
        public string ConbanfunConta { get; set; }
        public int? ConbanfunTerc { get; set; }
        public string ConbanfunNome { get; set; }
        public string ConbanfunCpf { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
