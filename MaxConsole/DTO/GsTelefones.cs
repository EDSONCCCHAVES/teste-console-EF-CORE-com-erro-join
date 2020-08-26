using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTelefones
    {
        public int CadtelId { get; set; }
        public int AssId { get; set; }
        public string CadtelDes { get; set; }
        public string CadtelNum { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
