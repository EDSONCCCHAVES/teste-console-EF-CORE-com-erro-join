using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTrajeto
    {
        public int TraId { get; set; }
        public int AssId { get; set; }
        public int? CidiniId { get; set; }
        public int? CidfimId { get; set; }
        public int? EstidaId { get; set; }
        public int? EstretId { get; set; }
        public double? TraKmida { get; set; }
        public double? TraKmret { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
