using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagProgramacao
    {
        public GsRagProgramacao()
        {
            GsArquivosProgramacao = new HashSet<GsArquivosProgramacao>();
        }

        public int DesenId { get; set; }
        public int AssId { get; set; }
        public int? UseId { get; set; }
        public int? CliforId { get; set; }
        public int? PrgId { get; set; }
        public int? DesenTipo { get; set; }
        public string DesenContato { get; set; }
        public string DesenAssunto { get; set; }
        public int? DesenMenu1 { get; set; }
        public int? DesenMenu2 { get; set; }
        public int? DesenMenu3 { get; set; }
        public string DesenCaminho { get; set; }
        public string DesenInfosol { get; set; }
        public int? DesenSit { get; set; }
        public int? DesenPrioridade { get; set; }
        public DateTime? DesenDatprevent { get; set; }
        public DateTime? DesenDatprevcli { get; set; }
        public DateTime? DesenDatent { get; set; }
        public string DesenVersao { get; set; }
        public string DesenInfodes { get; set; }
        public int? DesenProces1 { get; set; }
        public int? DesenProces2 { get; set; }
        public int? DesenProces3 { get; set; }
        public int? DesenProces4 { get; set; }
        public int? DesenProces5 { get; set; }
        public int? DesenProces6 { get; set; }
        public DateTime? DesenInicio { get; set; }
        public int? DesenOrdem { get; set; }
        public int? DesenSubordem { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public DateTime? DesenDatexec { get; set; }
        public string DesenInfoperacional { get; set; }
        public string DesenMotivo { get; set; }
        public string DesenImagem { get; set; }
        public int? SysProduto { get; set; }
        public string DesenvVersaoBuild { get; set; }
        public string DesenvComplexidade { get; set; }
        public int? DesenGravaprogramacao { get; set; }
        public string DesenTempoestim { get; set; }
        public string DesenTemporeal { get; set; }
        public int? DesenUrgente { get; set; }
        public string DesenDescMelhoria { get; set; }
        public string DesenCodcli { get; set; }

        public virtual ICollection<GsArquivosProgramacao> GsArquivosProgramacao { get; set; }
    }
}
