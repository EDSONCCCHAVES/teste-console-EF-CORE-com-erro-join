using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfeXml
    {
        public int NfexmlId { get; set; }
        public int? AssId { get; set; }
        public int? NfeloteId { get; set; }
        public string NfexmlXml { get; set; }
        public int? NfexmlTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
