using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaCnfMapper : ClassMapper<AuxiliaCnf>
	{
		public AuxiliaCnfMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_cnf");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.IdAuxiliarCnf).Column("id_auxiliar_cnf").Key(KeyType.Identity);  
		Map(prop => prop.Ordem).Column("ordem");  
			//
		}
	}
}