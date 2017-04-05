using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaPagamentoMapper : ClassMapper<AuxiliaPagamento>
	{
		public AuxiliaPagamentoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_pagamento");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.Ordem).Column("ordem");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.IdAuxiliarPagamento).Column("id_auxiliar_pagamento").Key(KeyType.Identity);  
			//
		}
	}
}