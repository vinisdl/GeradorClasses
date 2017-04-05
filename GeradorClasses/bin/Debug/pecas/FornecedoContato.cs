using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_contatos.
	/// </summary>
	public class FornecedoContato
	{
		public FornecedoContato()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string TelefoneRamal { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public string Email { get; set;} 
		public DateTime UltimoEnvioranking { get; set;} 
		public string Nome { get; set;} 
		public int TipoContato { get; set;} 
		public int IdFornecedorContato { get; set;} 
		public string CelularNumero { get; set;} 
		public bool RecebeNotificacao { get; set;} 
		public bool RecebeCnf { get; set;} 
		public bool NGestaoFornecedor { get; set;} 
		public bool Ativo { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string TelefoneDdd { get; set;} 
		public bool NProcessoEmaberto { get; set;} 
		public bool NEntregaAtrasada { get; set;} 
		public bool NItemCancelado { get; set;} 
		public string CelularRamal { get; set;} 
		public int PeriocidadeEnvioranking { get; set;} 
		public bool NNovoOrcamento { get; set;} 
		public int CodUsuario { get; set;} 
		public string CelularDdd { get; set;} 
		public string Msn { get; set;} 
		public bool NPedidoCancelado { get; set;} 
		public bool NPreventivaEntrega { get; set;} 
		public int CodFornecedor { get; set;} 
		public string TelefoneNumero { get; set;} 
		public string Idskype { get; set;} 
		public string Nextel { get; set;} 
	}
}