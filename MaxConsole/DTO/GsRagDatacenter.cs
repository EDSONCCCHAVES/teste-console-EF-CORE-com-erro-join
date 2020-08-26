using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagDatacenter
    {
        public int DcId { get; set; }
        public string DcHostname { get; set; }
        public string DcDatabase { get; set; }
        public string DcUsername { get; set; }
        public string DcPassword { get; set; }
    }
}
