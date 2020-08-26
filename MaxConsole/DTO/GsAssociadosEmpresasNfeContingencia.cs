using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosEmpresasNfeContingencia
    {
        public int EmpnfeconId { get; set; }
        public int? AssId { get; set; }
        public int? EmpnfeId { get; set; }
        public int? EmpnfeconTipoEmissao { get; set; }
        public string EmpnfeconJustificativa { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
