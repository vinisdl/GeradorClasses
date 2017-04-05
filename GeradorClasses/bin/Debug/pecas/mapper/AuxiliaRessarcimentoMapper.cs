using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaRessarcimentoMapper : ClassMapper<AuxiliaRessarcimento>
	{
		public AuxiliaRessarcimentoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_ressarcimento");
		Map(prop => prop.IdAuxiliarRessarcimento).Column("id_auxiliar_ressarcimento").Key(KeyType.Identity);  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.Ordem).Column("ordem");  
			//
		}
	}
}