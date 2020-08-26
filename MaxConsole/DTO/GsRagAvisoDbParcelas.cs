using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagAvisoDbParcelas
    {
        public int AvdId { get; set; }
        public int? AviId { get; set; }
        public int? AssId { get; set; }
        public DateTime? AvdDatvct { get; set; }
        public int? AvdParc { get; set; }
        public double? AvdValjur { get; set; }
        public double? AvdValmul { get; set; }
        public double? AvdValbol { get; set; }
        public double? AvdValsub { get; set; }
        public double? AvdValtot { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public int? AvdForma { get; set; }
        public double? AvdDesc { get; set; }
        public int? AvdOpe { get; set; }
        public int? AvdCon { get; set; }
        public double? AvdTxOpe { get; set; }
        public int? AvdDebcre { get; set; }
        public double? AvdCustas { get; set; }

        public virtual GsRagAvisoDb Avi { get; set; }
    }
}
