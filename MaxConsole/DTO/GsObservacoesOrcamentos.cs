using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsObservacoesOrcamentos
    {
        public GsObservacoesOrcamentos()
        {
            GsOrcamentosObservacoes = new HashSet<GsOrcamentosObservacoes>();
        }

        public int Id { get; set; }
        public int? AssId { get; set; }
        public string OboDescReduzida { get; set; }
        public string OboDescCompleta { get; set; }
        public int? OboUsuarioIdCad { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OboUsuarioIdAlt { get; set; }
        public DateTime? SysDatalt { get; set; }
        public int? SysDel { get; set; }
        public int Selecionado { get; set; }
        public bool? OboObsPadrao { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual ICollection<GsOrcamentosObservacoes> GsOrcamentosObservacoes { get; set; }
    }
}
