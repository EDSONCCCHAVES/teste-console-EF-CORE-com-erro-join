using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionariosCargosNiveis
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int FunId { get; set; }
        public int CarfunId { get; set; }
        public int CargnivId { get; set; }
        public int FcnSit { get; set; }
        public int? FcnUsuarioCad { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public int? FcnUsuarioAlt { get; set; }
        public DateTime? SysDatalt { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GsFuncionarios GsFuncionarios { get; set; }
    }
}
