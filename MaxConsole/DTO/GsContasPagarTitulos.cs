using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasPagarTitulos
    {
        public int CptId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public int? CliforId { get; set; }
        public int? GrptitId { get; set; }
        public int? SubgrpId { get; set; }
        public int? PlnctssubgrpId { get; set; }
        public int? PlnctsgrpId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public int? PlnctsctsId { get; set; }
        public string CptNumdoc { get; set; }
        public int? CptNumpar { get; set; }
        public DateTime? CptDatvenc { get; set; }
        public double? CptValpago { get; set; }
        public double? CptValpagar { get; set; }
        public double? CptDesc { get; set; }
        public double? CptJur { get; set; }
        public double? CptMulta { get; set; }
        public double? CptOutval { get; set; }
        public double? CptValtot { get; set; }
        public int? CptSit { get; set; }
        public string CptDes { get; set; }
        public string CptObs { get; set; }
        public DateTime? CptDatquit { get; set; }
        public int? OrcId { get; set; }
        public int? Id26 { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CptCor { get; set; }
        public int? CptTipo { get; set; }
        public int? CptOrigem { get; set; }
    }
}
