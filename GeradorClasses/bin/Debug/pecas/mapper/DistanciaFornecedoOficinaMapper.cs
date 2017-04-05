using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DistanciaFornecedoOficinaMapper : ClassMapper<DistanciaFornecedoOficina>
	{
		public DistanciaFornecedoOficinaMapper()
		{
			//
			Schema("pecas");
			Table("distancias_fornecedores_oficinas");
		Map(prop => prop.Valor).Column("valor");  
		Map(prop => prop.IdDistancia).Column("id_distancia").Key(KeyType.Identity);  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}