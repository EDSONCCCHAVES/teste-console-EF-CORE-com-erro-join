using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosHoraTecnica
    {
        public int EvthortecId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? EvtId { get; set; }
        public decimal? EvthortecValor { get; set; }
        public int? EvthortecHorini { get; set; }
        public int? EvthortecHorter { get; set; }
        public DateTime? EvthortecData { get; set; }
        public double? EvthortecHortot { get; set; }
        public decimal? EvthortecValortotal { get; set; }
        public int? EvthortecManual { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? EvthortecDatter { get; set; }
        public string LogUser { get; set; }
        public string LogNumip { get; set; }
        public DateTime? LogData { get; set; }
        public string LogUsercad { get; set; }
        public string LogNumipcad { get; set; }
        public DateTime? LogDatcad { get; set; }
        public int? EvthortecFlag { get; set; }
    }
}
