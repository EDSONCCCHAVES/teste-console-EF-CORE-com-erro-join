using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMobiliario
    {
        public int MobId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? AssempsetId { get; set; }
        public int? GrpmobId { get; set; }
        public string MobNome { get; set; }
        public string MobDes { get; set; }
        public string MobSerie { get; set; }
        public string MobPatrimonio { get; set; }
        public DateTime? MobDatacompra { get; set; }
        public decimal? MobValorcompra { get; set; }
        public DateTime? MobDatbaixa { get; set; }
        public int? MobMesdep { get; set; }
        public string MobMotbaixa { get; set; }
        public string MobEsptec { get; set; }
        public int? MobOpe { get; set; }
        public int? MobSit { get; set; }
        public int? MobsubId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
