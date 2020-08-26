using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosDocumentosOrcamentos
    {
        public int Id { get; set; }
        public int AssdocId { get; set; }
        public int AssId { get; set; }
        public int OrcId { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }

        public virtual GsAssociadosDocumentos Ass { get; set; }
    }
}
