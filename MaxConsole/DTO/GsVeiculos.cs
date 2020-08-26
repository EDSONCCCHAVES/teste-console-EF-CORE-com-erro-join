using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsVeiculos
    {
        public int VclId { get; set; }
        public int? AssId { get; set; }
        public string VclModelo { get; set; }
        public string VclMarca { get; set; }
        public string VclEspecie { get; set; }
        public int? VclCombustivel { get; set; }
        public string VclAnoFabricacao { get; set; }
        public string VclAnoModelo { get; set; }
        public string VclPlaca { get; set; }
        public string VclCpfcnpj { get; set; }
        public string VclNome { get; set; }
        public string VclRenavam { get; set; }
        public string VclCor { get; set; }
        public string VclChassi { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EmpId { get; set; }
    }
}
