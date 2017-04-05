using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itensimportacao.
	/// </summary>
	public class Itensimportacao
	{
		public Itensimportacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Referencia { get; set;} 
		public int Audatex14StatuRecebido { get; set;} 
		public string SequenciaVistoria { get; set;} 
		public int CodReferenciaItemportal { get; set;} 
		public string AudatexIdentificador { get; set;} 
		public bool Pintar { get; set;} 
		public int Acao { get; set;} 
		public bool Duplicado { get; set;} 
		public string Pathnumber { get; set;} 
		public bool Trocar { get; set;} 
		public bool Recuperar { get; set;} 
		public int Quantidade { get; set;} 
		public string Descricao { get; set;} 
		public Int64 Idpec { get; set;} 
		public int Audatex14Retorno { get; set;} 
		public int CodSegmento { get; set;} 
		public bool Fornece { get; set;} 
		public string OrcamentoRetornado { get; set;} 
		public decimal Valorlista { get; set;} 
		public int IdItemimportacao { get; set;} 
		public decimal ValorOficina { get; set;} 
		public int CodImportacao { get; set;} 
	}
}