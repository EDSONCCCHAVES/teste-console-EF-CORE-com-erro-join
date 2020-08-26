using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseXmlMetodos
    {
        public int Id { get; set; }
        public int ProvedorId { get; set; }
        public int MetodoId { get; set; }
        public string XmlTopo { get; set; }
        public string XmlRps { get; set; }
        public string XmlFim { get; set; }
        public string XmlCompleto { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GtNfseMetodos Metodo { get; set; }
        public virtual GtProvedores Provedor { get; set; }
    }
}
