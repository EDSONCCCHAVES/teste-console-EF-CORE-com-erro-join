using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsArquivosProgramacao
    {
        public int ArqprogId { get; set; }
        public int AssId { get; set; }
        public int DesenId { get; set; }
        public string ArqprogDesc { get; set; }
        public string ArqprogArq { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }

        public virtual GsRagProgramacao GsRagProgramacao { get; set; }
    }
}
