using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfsePrefeituras
    {
        public int NfseprefId { get; set; }
        public int NfseprefCod { get; set; }
        public string NfseprefNome { get; set; }
        public string NfseprefUf { get; set; }
        public int NfseprefLote { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
    }
}
