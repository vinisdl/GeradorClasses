using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DescontoClienteGrupoMapper : ClassMapper<DescontoClienteGrupo>
	{
		public DescontoClienteGrupoMapper()
		{
			//
			Schema("pecas");
			Table("descontos_clientes_grupos");
		Map(prop => prop.Desconto).Column("desconto");  
		Map(prop => prop.IdDescontoClienteGrupo).Column("id_desconto_cliente_grupo").Key(KeyType.Identity);  
		Map(prop => prop.CodGrupopecaMarca).Column("cod_grupopeca_marca");  
		Map(prop => prop.CodDescontoCliente).Column("cod_desconto_cliente");  
			//
		}
	}
}