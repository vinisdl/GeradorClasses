using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaDevolucaoMapper : ClassMapper<AuxiliaDevolucao>
	{
		public AuxiliaDevolucaoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_devolucao");
		Map(prop => prop.IdAuxiliarDevolucao).Column("id_auxiliar_devolucao").Key(KeyType.Identity);  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.Ordem).Column("ordem");  
			//
		}
	}
}