using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContratos
    {
        public int CttId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public int? AssdocId { get; set; }
        public int? AssdocLayout { get; set; }
        public DateTime? CttDatemi { get; set; }
        public DateTime? CttDatcan { get; set; }
        public int? CttNum { get; set; }
        public string CttDoc { get; set; }
        public int? CttSit { get; set; }
        public decimal? CttValor { get; set; }
        public string CttNomtest1 { get; set; }
        public string CttDoctest1 { get; set; }
        public string CttMontest2 { get; set; }
        public string CttDoctest2 { get; set; }
        public string CttMotcan { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
