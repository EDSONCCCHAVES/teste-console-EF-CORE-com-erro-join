using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class TmpSetoresContas
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int EmpId { get; set; }
        public int AssempsetId { get; set; }
        public int PlnctsgrpId { get; set; }
        public int? PlnctssubgrpId { get; set; }
        public int? PlnctsctsId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
    }
}
