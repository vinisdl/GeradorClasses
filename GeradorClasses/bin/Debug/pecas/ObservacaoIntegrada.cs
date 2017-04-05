using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : observacoes_integradas.
	/// </summary>
	public class ObservacaoIntegrada
	{
		public ObservacaoIntegrada()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataCriacao { get; set;} 
		public bool Confidencial { get; set;} 
		public string Mensagem { get; set;} 
		public int IdObservacaoIntegrada { get; set;} 
		public DateTime DataIntegracao { get; set;} 
		public int CodPedido { get; set;} 
		public int OpcaoZurich { get; set;} 
		public string CodigoSinistro { get; set;} 
		public string NomeUsuario { get; set;} 
		public int CodCliente { get; set;} 
		public bool Gravando { get; set;} 
		public bool IntegracaoCilia { get; set;} 
		public bool IntegracaoManual { get; set;} 
	}
}