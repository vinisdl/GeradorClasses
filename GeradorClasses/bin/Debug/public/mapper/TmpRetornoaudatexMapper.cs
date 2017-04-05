using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class TmpRetornoaudatexMapper : ClassMapper<TmpRetornoaudatex>
	{
		public TmpRetornoaudatexMapper()
		{
			//
			Schema("public");
			Table("tmp_retornoaudatex");
		Map(prop => prop.Id).Column("id").Key(KeyType.Identity);  
		Map(prop => prop.Pedido).Column("pedido");  
		Map(prop => prop.Placa).Column("placa");  
		Map(prop => prop.Orc).Column("orc");  
		Map(prop => prop.Statu).Column("status");  
		Map(prop => prop.Numval).Column("numval");  
		Map(prop => prop.Sinistro).Column("sinistro");  
			//
		}
	}
}