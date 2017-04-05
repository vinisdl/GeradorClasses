using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido.
	/// </summary>
	public class Itenspedido
	{
		public Itenspedido()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Statu { get; set;} 
		public int CancelamentoCodUsuario { get; set;} 
		public int AutorizacaoCodItempedidoFornecedor { get; set;} 
		public bool Autorizado { get; set;} 
		public int CodPedido { get; set;} 
		public int StatuItemOficina { get; set;} 
		public bool CataPecaLocalizado { get; set;} 
		public DateTime DataEnvioFinalizacao { get; set;} 
		public int CodUsuarioSolicitacaoCataPeca { get; set;} 
		public int CodSegmento { get; set;} 
		public bool SemPrevisao { get; set;} 
		public int CodMotivoSolicitacaoDevolucao { get; set;} 
		public int CodReferenciaItemportal { get; set;} 
		public int CodGrupo { get; set;} 
		public DateTime DataEnvioCancelamento { get; set;} 
		public string Pathnumber { get; set;} 
		public decimal Valorlista { get; set;} 
		public Int64 Idpec { get; set;} 
		public int IdItempedido { get; set;} 
		public string Descricao { get; set;} 
		public string RetornoCataPeca { get; set;} 
		public bool ItemEmBo { get; set;} 
		public int CodMotivoCancelamento { get; set;} 
		public bool Cancelado { get; set;} 
		public decimal VlrOficina { get; set;} 
		public bool CataPecaFinalizado { get; set;} 
		public DateTime DataSolicitacaoCataPeca { get; set;} 
		public string PathnumberAlternativo { get; set;} 
		public bool CancelamentoSolicitado { get; set;} 
		public bool CataPecaAcionado { get; set;} 
		public int AutorizacaoCodUsuario { get; set;} 
		public string Audatex14Identificador { get; set;} 
		public DateTime DataFinalizacaoCataPeca { get; set;} 
		public int QuantidadeTrocar { get; set;} 
		public DateTime CancelamentoData { get; set;} 
		public int Quantidade { get; set;} 
	}
}