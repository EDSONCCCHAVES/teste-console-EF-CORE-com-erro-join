using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLogAcesso
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int? UsuarioId { get; set; }
        public string LogIp { get; set; }
        public string LogMacadress { get; set; }
        public string LogVersao { get; set; }
        public string LogHost { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
        public int? LogAtivo { get; set; }
        public int? LogIdConexao { get; set; }
    }
}
