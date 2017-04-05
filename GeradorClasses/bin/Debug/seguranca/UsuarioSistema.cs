using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : usuarios_sistemas.
	/// </summary>
	public class UsuarioSistema
	{
		public UsuarioSistema()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool Gerente { get; set;} 
		public int CodSistema { get; set;} 
		public int IdUsuarioSistema { get; set;} 
		public bool Ativo { get; set;} 
		public int CodUsuario { get; set;} 
		public int CodUsuarioExterno { get; set;} 
	}
}