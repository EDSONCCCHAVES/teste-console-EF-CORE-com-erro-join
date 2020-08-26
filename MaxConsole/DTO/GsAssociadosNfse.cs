using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosNfse
    {
        public int AssnfseId { get; set; }
        public int AssId { get; set; }
        public int? AssnfsePrefeitura { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
