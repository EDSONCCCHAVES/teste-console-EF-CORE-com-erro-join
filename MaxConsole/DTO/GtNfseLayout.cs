using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseLayout
    {
        public int Id { get; set; }
        public int ConfiguracaoId { get; set; }
        public string LayTitulo { get; set; }
        public string LayCampo { get; set; }
        public string LayObjeto { get; set; }
        public double LayLargura { get; set; }
        public double LayAltura { get; set; }
        public int LayTipo { get; set; }
        public int LayTamanho { get; set; }
        public double LayMargemSuperior { get; set; }
        public double LayMargemEsquerda { get; set; }
        public string LayAlinhamentoHorizontal { get; set; }
        public string LayAlinhamentoVertical { get; set; }
        public string LayNomeClasse { get; set; }
        public string LayCampoClasse { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public string LayValorPadrao { get; set; }
        public int LayFlagUtilizarValorPadrao { get; set; }
        public string LayFormatacaoCampo { get; set; }

        public virtual GtNfseConfiguracaoCliente Configuracao { get; set; }
    }
}
