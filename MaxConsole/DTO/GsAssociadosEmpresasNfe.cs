using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosEmpresasNfe
    {
        public int EmpnfeId { get; set; }
        public int? AssId { get; set; }
        public int? EmpId { get; set; }
        public string EmpnfeUtilizar { get; set; }
        public int? EmpnfeAmbiente { get; set; }
        public int? EmpnfeRegimeTributario { get; set; }
        public int? EmpnfeTipoEmissao { get; set; }
        public int? EmpnfeFormatoImpressao { get; set; }
        public string EmpnfeIeSt { get; set; }
        public int? EmpnfeUltimaNfe { get; set; }
        public int? EmpnfeSerie { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string EmpnfeMsgEmail { get; set; }
        public int? EmpnfeEmailSsl { get; set; }
        public string EmpnfeAssuntoEmail { get; set; }
        public int? EmpnfePortSmtp { get; set; }
        public string EmpnfePassSmtp { get; set; }
        public string EmpnfeUserSmtp { get; set; }
        public string EmpnfeServidorSmtp { get; set; }
        public string EmpnfeChave { get; set; }
        public string EmpnfeSenhac { get; set; }
    }
}
