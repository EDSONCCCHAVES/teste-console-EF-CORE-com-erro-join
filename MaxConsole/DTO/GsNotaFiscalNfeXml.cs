using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalNfeXml
    {
        public int NfnfexmlId { get; set; }
        public int? AssId { get; set; }
        public int? NfId { get; set; }
        public string NfnfexmlXml { get; set; }
        public string NfnfexmlProtocolo { get; set; }
        public string NfnfexmlChave { get; set; }
        public string NfnfexmlProtocoloCancelamento { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
    }
}
