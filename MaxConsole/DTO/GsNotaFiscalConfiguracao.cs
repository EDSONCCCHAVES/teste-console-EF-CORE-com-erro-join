using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalConfiguracao
    {
        public int CfgnfId { get; set; }
        public int AssId { get; set; }
        public int EmpId { get; set; }
        public int? NotserId { get; set; }
        public string CfgnfDes { get; set; }
        public string CfgnfName { get; set; }
        public int? CfgnfAltura { get; set; }
        public int? CfgnfLargura { get; set; }
        public int? CfgnfMargsup { get; set; }
        public int? CfgnfMargesq { get; set; }
        public int? CfgnfSit { get; set; }
        public int? CfgnfAlinhamento { get; set; }
        public int? CfgnfGrupo { get; set; }
        public int? CfgnfFont { get; set; }
        public int? CfgnfFontBold { get; set; }
        public int? CfgnfFontItalic { get; set; }
        public int? CfgnfFontTam { get; set; }
        public int? CfgnfOrd { get; set; }
        public int? CfgnfAtivatexto { get; set; }
        public string CfgnfTextolivre { get; set; }
        public int? CfgnfEspacolinha { get; set; }
        public int? CfgnfEspacolinhacustom { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
