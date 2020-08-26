using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosDocumentosLog
    {
        public int AssdoclogId { get; set; }
        public int AssId { get; set; }
        public int? AssdocId { get; set; }
        public int? AssdoclogTipo { get; set; }
        public int? UseId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
