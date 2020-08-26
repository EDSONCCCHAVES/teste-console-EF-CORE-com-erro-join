using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFuncionarios
    {
        public GsFuncionarios()
        {
            GsFuncionariosCargosNiveis = new HashSet<GsFuncionariosCargosNiveis>();
            GsRagProgramadores = new HashSet<GsRagProgramadores>();
        }

        public int FunId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public int? FunCodmat { get; set; }
        public string FunNome { get; set; }
        public string FunApelido { get; set; }
        public int? FunSexo { get; set; }
        public int? FunEstciv { get; set; }
        public string FunRgdoc { get; set; }
        public int? FunRguf { get; set; }
        public DateTime? FunRgexp { get; set; }
        public string FunCartmot { get; set; }
        public string FunGrauinst { get; set; }
        public string FunRgorgemi { get; set; }
        public string FunCpf { get; set; }
        public DateTime? FunDatnas { get; set; }
        public string FunEnddes { get; set; }
        public string FunEndnum { get; set; }
        public string FunEndcpl { get; set; }
        public string FunEndcep { get; set; }
        public string FunEndbai { get; set; }
        public string FunDddfone { get; set; }
        public string FunDddcel { get; set; }
        public string FunFone { get; set; }
        public string FunCel { get; set; }
        public string FunEmail { get; set; }
        public DateTime? FunDatadm { get; set; }
        public DateTime? FunDatdem { get; set; }
        public int? FunCoddem { get; set; }
        public int? FunSit { get; set; }
        public int? CidId { get; set; }
        public int? CargnivId { get; set; }
        public int? CarfunId { get; set; }
        public int? FunTipo { get; set; }
        public string FunSenhacartao { get; set; }
        public int? CliforId { get; set; }
        public int? FunForn { get; set; }
        public string FunObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string FunPis { get; set; }
        public string FunCtps { get; set; }
        public string FunNomepai { get; set; }
        public string FunNomemae { get; set; }
        public string FunNextel { get; set; }
        public string FunContato { get; set; }
        public int? FunLb { get; set; }
        public long? FunLbinfo { get; set; }
        public string FunColor { get; set; }
        public string FunColorsec { get; set; }
        public byte[] FunImgdig { get; set; }
        public string FunImgfoto { get; set; }
        public int? FunVendedor { get; set; }
        public string FunLocnascid { get; set; }
        public string FunLocnasest { get; set; }
        public string FunNomeconjugue { get; set; }
        public decimal? FunFolhaSalario { get; set; }
        public decimal? FunFolhaAjudacusto { get; set; }
        public decimal? FunFolhaPensao { get; set; }
        public decimal? FunFolhaQuinq { get; set; }
        public decimal? FunFolhaValtransp { get; set; }
        public double? FunFolhaDescvaltransp { get; set; }
        public decimal? FunFolhaBonus { get; set; }
        public decimal? FunFolhaRefeicao { get; set; }
        public double? FunFolhaInss { get; set; }
        public double? FunFolhaIrpf { get; set; }
        public decimal? FunFolhaPlamed { get; set; }
        public decimal? FunFolhaPartlucr { get; set; }
        public decimal? FunFolhaSalfam { get; set; }
        public double? FunFolhaVale { get; set; }
        public int? FunBanid { get; set; }
        public string FunBanage { get; set; }
        public string FunBancont { get; set; }
        public int? FunBantip { get; set; }
        public int? FunBanterc { get; set; }
        public string FunBancpf { get; set; }
        public string FunBannomtit { get; set; }
        public string FunBanparentesco { get; set; }
        public int? FunPaghor { get; set; }
        public decimal? FunPagvaldia { get; set; }
        public decimal? FunPagvalhor { get; set; }
        public int? FunPagunicodia { get; set; }
        public int? AssempsetId { get; set; }
        public int? FunApoiotecnico { get; set; }
        public DateTime? FunHoraentrada { get; set; }
        public DateTime? FunHorasaidaintervalo { get; set; }
        public DateTime? FunHoraentradaintervalo { get; set; }
        public DateTime? FunHorasaida { get; set; }
        public double? FunGratificacao { get; set; }
        public int? FunMotorista { get; set; }
        public string FunTitulo { get; set; }
        public DateTime? FunDateadm { get; set; }
        public DateTime? FunDateper { get; set; }
        public DateTime? FunDatetro { get; set; }
        public DateTime? FunDatedem { get; set; }
        public double? FunValvt { get; set; }
        public double? FunValvr { get; set; }
        public double? FunValps { get; set; }
        public double? FunValpd { get; set; }
        public string FunDesvt { get; set; }
        public string FunDesvr { get; set; }
        public string FunDesps { get; set; }
        public string FunDespd { get; set; }
        public DateTime? FunDatpis { get; set; }
        public DateTime? FunDatevencimento { get; set; }

        public virtual ICollection<GsFuncionariosCargosNiveis> GsFuncionariosCargosNiveis { get; set; }
        public virtual ICollection<GsRagProgramadores> GsRagProgramadores { get; set; }
    }
}
