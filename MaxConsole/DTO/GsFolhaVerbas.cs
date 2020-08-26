using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFolhaVerbas
    {
        public int VerbfolId { get; set; }
        public int AssId { get; set; }
        public int? VerbfolCod { get; set; }
        public string VerbfolDes { get; set; }
        public int? VerbfolTipo { get; set; }
        public int? VerbfolGerfin { get; set; }
        public int? GrptitId { get; set; }
        public int? SubgrpId { get; set; }
        public int? PlnctsgrpId { get; set; }
        public int? PlnctssubgrpId { get; set; }
        public int? PlnctsctsId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public int? VerbfolAltdes { get; set; }
        public int? CliforId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public bool? Inss { get; set; }
    }
}
