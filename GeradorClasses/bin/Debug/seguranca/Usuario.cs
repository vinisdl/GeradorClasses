using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : usuarios.
	/// </summary>
	public class Usuario
	{
		public Usuario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool AuxiliarFase2 { get; set;} 
		public int StatuLogistica { get; set;} 
		public string UltimoLoginIp { get; set;} 
		public int OrdemLogistica { get; set;} 
		public string Senha { get; set;} 
		public int CodPerito { get; set;} 
		public string Username { get; set;} 
		public DateTime UltimoLoginData { get; set;} 
		public string TokenRecuperacaoSenha { get; set;} 
		public string NomeCompleto { get; set;} 
		public bool Ativo { get; set;} 
		public string CnpjCpf { get; set;} 
		public string NomeRazaoSocial { get; set;} 
		public bool Habilitado { get; set;} 
		public string UltimaSenha { get; set;} 
		public DateTime DataTrocaSenha { get; set;} 
		public int CodOficina { get; set;} 
		public int IdUsuario { get; set;} 
		public DateTime CriacaoData { get; set;} 
		public string Email { get; set;} 
	}
}