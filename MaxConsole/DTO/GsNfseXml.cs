using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfseXml
    {
        public int NfsexmlId { get; set; }
        public int AssId { get; set; }
        public string NfsexmlXml { get; set; }
        public int? NfsexmlTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
