using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaProgramacaoBuilds
    {
        public int Id { get; set; }
        public int DesenId { get; set; }
        public int AssId { get; set; }
        public int? PrbTesterId { get; set; }
        public int? PrbPrgId { get; set; }
        public string PrbBuildNum { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
