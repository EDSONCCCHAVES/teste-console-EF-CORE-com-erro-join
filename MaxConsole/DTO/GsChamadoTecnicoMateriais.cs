using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsChamadoTecnicoMateriais
    {
        public int ChatecmatId { get; set; }
        public int AssId { get; set; }
        public int? ChatecId { get; set; }
        public int? MatId { get; set; }
        public int? ChatecmatQtdesaida { get; set; }
        public int? ChatecmatQtderetorno { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
