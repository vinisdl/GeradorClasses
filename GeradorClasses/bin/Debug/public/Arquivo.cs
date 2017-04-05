using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : arquivos.
	/// </summary>
	public class Arquivo
	{
		public Arquivo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime CriacaoData { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
		public int Tamanho { get; set;} 
		public int IdArquivo { get; set;} 
		public string Nome { get; set;} 
		public Byte[] Conteudo { get; set;} 
		public string MimeType { get; set;} 
		public string Caminho { get; set;} 
		public string Descricao { get; set;} 
	}
}