using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsControleContratos
    {
        public int GerconId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public int? EvtId { get; set; }
        public int? AssdocId { get; set; }
        public int? CliforId { get; set; }
        public string GetconDes { get; set; }
        public int? GetconSit { get; set; }
        public DateTime? GetconDatemi { get; set; }
        public DateTime? GetconDatvct { get; set; }
        public DateTime? GetconDatalt { get; set; }
        public DateTime? GetconDataprov { get; set; }
        public int? GetconType { get; set; }
        public int? GetconFiletype { get; set; }
        public string GetconObs { get; set; }
        public string GetconFile { get; set; }
        public int? GetconNum { get; set; }
        public int? GetconCtl { get; set; }
        public string GetconTestemunha1 { get; set; }
        public string GetconDoctestemunha1 { get; set; }
        public string GetconTestemunha2 { get; set; }
        public string GetconDoctestemunha2 { get; set; }
        public string GetconTestemunha3 { get; set; }
        public string GetconDoctestemunha3 { get; set; }
        public string GetconTestemunha4 { get; set; }
        public string GetconDoctestemunha4 { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
