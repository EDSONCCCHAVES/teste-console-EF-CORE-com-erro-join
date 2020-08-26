using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLicencaAcesso
    {
        public int LicaceId { get; set; }
        public int? AssId { get; set; }
        public int? CtrId { get; set; }
        public int? LicaceSit { get; set; }
        public string LicaceCod { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public string LicaceOs { get; set; }
        public string LicaceOsid { get; set; }
        public string LicaceCpuname { get; set; }
        public string LicaceComputername { get; set; }
    }
}
