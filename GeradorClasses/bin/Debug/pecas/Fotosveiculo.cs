using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fotosveiculos.
	/// </summary>
	public class Fotosveiculo
	{
		public Fotosveiculo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int AlteracaoCodUsuario { get; set;} 
		public int CodArquivo { get; set;} 
		public int CodVeiculo { get; set;} 
		public int IdFotoveiculo { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string Descricao { get; set;} 
	}
}