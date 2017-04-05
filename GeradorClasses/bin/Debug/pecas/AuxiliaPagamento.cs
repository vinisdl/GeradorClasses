using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : auxiliares_pagamento.
	/// </summary>
	public class AuxiliaPagamento
	{
		public AuxiliaPagamento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public bool Ativo { get; set;} 
		public int Ordem { get; set;} 
		public int CodUsuario { get; set;} 
		public int IdAuxiliarPagamento { get; set;} 
	}
}