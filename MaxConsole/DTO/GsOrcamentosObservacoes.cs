using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosObservacoes
    {
        public int Id { get; set; }
        public int? OboId { get; set; }
        public int? OrcId { get; set; }
        public int? AssId { get; set; }
        public int? OrcUsuarioIdCad { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OrcUsuarioIdAlt { get; set; }
        public DateTime? SysDatalt { get; set; }
        public int? SysDel { get; set; }
        public int OboHabilitado { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GsObservacoesOrcamentos Obo { get; set; }
    }
}
