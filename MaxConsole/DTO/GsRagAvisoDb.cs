using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagAvisoDb
    {
        public GsRagAvisoDb()
        {
            GsRagAvisoDbParcelas = new HashSet<GsRagAvisoDbParcelas>();
        }

        public int AviId { get; set; }
        public int? AssId { get; set; }
        public int? CliforId { get; set; }
        public string AviMsg { get; set; }
        public string AviObs { get; set; }
        public DateTime? AviDatemi { get; set; }
        public DateTime? AviDatvct { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AviForma { get; set; }
        public int? SysDel { get; set; }
        public double? AviValdes { get; set; }
        public double? AviValtot { get; set; }
        public int? AviContato { get; set; }
        public int? AviSit { get; set; }
        public double? AviCustas { get; set; }

        public virtual ICollection<GsRagAvisoDbParcelas> GsRagAvisoDbParcelas { get; set; }
    }
}
