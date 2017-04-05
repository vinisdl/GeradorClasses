using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : arquivos_log.
	/// </summary>
	public class ArquivoLog
	{
		public ArquivoLog()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Operacao { get; set;} 
		public int IdArquivoLog { get; set;} 
		public DateTime Datahora { get; set;} 
		public int CodArquivo { get; set;} 
	}
}