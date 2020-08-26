using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseLigacaoCamposTagsXml
    {
        public int Id { get; set; }
        public int ProvedorId { get; set; }
        public int IdCampo { get; set; }
        public int IdTag { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GtNfseCamposXml IdCampoNavigation { get; set; }
        public virtual GtNfseTagsXml IdTagNavigation { get; set; }
        public virtual GtProvedores Provedor { get; set; }
    }
}
