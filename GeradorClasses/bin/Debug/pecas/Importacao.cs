using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : importacoes.
	/// </summary>
	public class Importacao
	{
		public Importacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string SegCpfCnpj { get; set;} 
		public string OfiCpfCnpj { get; set;} 
		public decimal CustoLiberadoOficina { get; set;} 
		public string Apolice { get; set;} 
		public string VeiPlaca { get; set;} 
		public int Audatex14VersaoOrcamento { get; set;} 
		public string CaminhoImgPortal { get; set;} 
		public int CodArquivoNotaCobertura { get; set;} 
		public int CodOficina { get; set;} 
		public int VeiAnofab { get; set;} 
		public int Audatex14NumeroOrcamento { get; set;} 
		public DateTime AciData { get; set;} 
		public string ArqNome { get; set;} 
		public string OfiNome { get; set;} 
		public int AutorizacaoTipo { get; set;} 
		public string VeiChassi { get; set;} 
		public DateTime ViData { get; set;} 
		public string PeritoNome { get; set;} 
		public bool IntegracaoCilia { get; set;} 
		public string PerCpf { get; set;} 
		public int CodUsuarioImportacao { get; set;} 
		public string ViNumero { get; set;} 
		public int QtdPeca { get; set;} 
		public int CodigoOficina { get; set;} 
		public string OfiFax { get; set;} 
		public int VeiPorta { get; set;} 
		public bool IntegracaoOrion { get; set;} 
		public Int64 NumeroPedido { get; set;} 
		public string AciEstado { get; set;} 
		public string OfiBairro { get; set;} 
		public float? CustoPecaDesconto { get; set;} 
		public string AciLocal { get; set;} 
		public int VeiAnomod { get; set;} 
		public string RemetenteCnpj { get; set;} 
		public string SegTelefoneDdd { get; set;} 
		public string PerNome { get; set;} 
		public string OfiEndereco { get; set;} 
		public string AudatexIdentificador { get; set;} 
		public decimal Franquia { get; set;} 
		public bool ImportacaoAutomatica { get; set;} 
		public string Sinistro { get; set;} 
		public int CodAnalista { get; set;} 
		public bool ReativacaoParcial { get; set;} 
		public decimal CustoMecanica { get; set;} 
		public bool DePara { get; set;} 
		public string VeiTcor { get; set;} 
		public decimal ValorTotalPeca { get; set;} 
		public int CodArquivoOrcamentoHtml { get; set;} 
		public bool Terceiro { get; set;} 
		public string SegTelefoneRamal { get; set;} 
		public string IdPedidoAudatex { get; set;} 
		public string SegRg { get; set;} 
		public string CodigoMarca { get; set;} 
		public string OfiCidade { get; set;} 
		public decimal CustoFunilaria { get; set;} 
		public DateTime DataRecebimento { get; set;} 
		public string SegEndLogradouro { get; set;} 
		public string SegCidade { get; set;} 
		public string VeiCor { get; set;} 
		public string AciCidade { get; set;} 
		public string PeritoCpf { get; set;} 
		public int IdImportacao { get; set;} 
		public string OfiCep { get; set;} 
		public decimal CustoTapecaria { get; set;} 
		public int CodCliente { get; set;} 
		public bool IntegracaoEspecifica { get; set;} 
		public string SegBairro { get; set;} 
		public int CodPerito { get; set;} 
		public string SegTelefoneNumero { get; set;} 
		public decimal CustoEletrica { get; set;} 
		public string SegCep { get; set;} 
		public decimal CustoPintura { get; set;} 
		public string VeiTipo { get; set;} 
		public string OfiEmail { get; set;} 
		public int VeiKm { get; set;} 
		public string SegEndComplemento { get; set;} 
		public string CliCnpj { get; set;} 
		public decimal CustoPecaBruto { get; set;} 
		public int CodUsuarioCorrecao { get; set;} 
		public string Ramo { get; set;} 
		public int CodSucursal { get; set;} 
		public int Statu { get; set;} 
		public string ViNome { get; set;} 
		public string ViCodigo { get; set;} 
		public string VeiString { get; set;} 
		public string Corretor { get; set;} 
		public string SegUf { get; set;} 
		public string CodigoModelo { get; set;} 
		public string CliNome { get; set;} 
		public decimal Valorseg { get; set;} 
		public string OfiRg { get; set;} 
		public string VeiMotor { get; set;} 
		public string SegEndNumero { get; set;} 
		public string VeiMarca { get; set;} 
		public DateTime DataAbertura { get; set;} 
		public DateTime Audatex14EnvioretornoNaoimportado { get; set;} 
		public string SegEmail { get; set;} 
		public decimal CustoTerceiro { get; set;} 
		public string OfiUf { get; set;} 
		public bool Mobile { get; set;} 
		public string VeiComb { get; set;} 
		public int ViCodReguladora { get; set;} 
		public string VeiModelo { get; set;} 
		public string LinkFoto { get; set;} 
		public string Cancelado { get; set;} 
		public decimal CustoPecaLiquido { get; set;} 
		public string AnalistaSinistro { get; set;} 
		public DateTime DataSinistro { get; set;} 
		public DateTime DataImportacao { get; set;} 
		public int Complemento { get; set;} 
		public string ObSeguradora { get; set;} 
		public DateTime DataCorrecao { get; set;} 
		public string SegNome { get; set;} 
		public string OfiTelefone { get; set;} 
		public string SegFax { get; set;} 
	}
}