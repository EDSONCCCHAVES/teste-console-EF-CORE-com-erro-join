using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosEmpresasNfse
    {
        public int EmpnfseId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public string EmpnfseUtilizar { get; set; }
        public int? EmpnfseAmbiente { get; set; }
        public string EmpnfseTiporecolhimento { get; set; }
        public string EmpnfseOperacao { get; set; }
        public string EmpnfseTributacao { get; set; }
        public double? EmpnfseAliquotaPis { get; set; }
        public double? EmpnfseAliquotaCofins { get; set; }
        public double? EmpnfseAliquotaInss { get; set; }
        public double? EmpnfseAliquotaIr { get; set; }
        public double? EmpnfseAliquotaCsll { get; set; }
        public string EmpnfseSerieRps { get; set; }
        public int? EmpnfseUltimaRpsEmitida { get; set; }
        public int? EmpnfseSeriePrestacao { get; set; }
        public int? EmpnfsePrefeitura { get; set; }
        public string EmpnfseAssinar { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int EmpnfseIncentivadorCultural { get; set; }
        public int EmpnfseOpSimplesNacional { get; set; }
    }
}
