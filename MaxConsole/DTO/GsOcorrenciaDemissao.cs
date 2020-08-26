using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOcorrenciaDemissao
    {
        public int OcodemId { get; set; }
        public int AssId { get; set; }
        public string OcodemDes { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
