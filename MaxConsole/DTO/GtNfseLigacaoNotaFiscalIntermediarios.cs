using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseLigacaoNotaFiscalIntermediarios
    {
        public int Id { get; set; }
        public int NotaFiscalId { get; set; }
        public int AssId { get; set; }
        public int EmpId { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GsAssociadosEmpresas GsAssociadosEmpresas { get; set; }
    }
}
