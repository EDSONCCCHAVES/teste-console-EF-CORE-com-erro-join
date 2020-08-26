using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsParametrosPlanoContas
    {
        public int ParplnctsId { get; set; }
        public int AssId { get; set; }
        public string ParplnctsMod { get; set; }
        public string ParplnctsDes { get; set; }
        public int? ParplnctsTipo { get; set; }
        public int? PlnctsgrpId { get; set; }
        public int? PlnctssubgrpId { get; set; }
        public int? PlnctsctsId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
