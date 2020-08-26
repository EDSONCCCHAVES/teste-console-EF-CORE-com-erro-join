using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEquipamentosRecebidosApp
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public string EqtrecCodBarras { get; set; }
        public int EqtrecSit { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
    }
}
