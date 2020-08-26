using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfeCondicoesPagto
    {
        public int NfeconpagId { get; set; }
        public int NfeconpagTipoId { get; set; }
        public string NfeconpagDescricao { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
    }
}
