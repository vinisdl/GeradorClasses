using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itens_bo.
	/// </summary>
	public class ItemBo
	{
		public ItemBo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Descricao { get; set;} 
		public int IdItemBo { get; set;} 
		public string Parthnumber { get; set;} 
		public int CodMarca { get; set;} 
	}
}