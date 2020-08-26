using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaKambanSprint
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int DesenId { get; set; }
        public int SptId { get; set; }
        public DateTime KspDatini { get; set; }
        public DateTime KspDatfin { get; set; }
        public double? KspPeriodo { get; set; }
        public byte? KspStatus { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
