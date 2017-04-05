using DapperExtensions.Mapper; 
namespace Prismatec{
	public class TokemMapper : ClassMapper<Tokem>
	{
		public TokemMapper()
		{
			//
			Schema("pecas");
			Table("tokens");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.CodSolicitacao).Column("cod_solicitacao");  
		Map(prop => prop.Token).Column("token");  
		Map(prop => prop.CodNotaFiscal).Column("cod_nota_fiscal");  
		Map(prop => prop.IdToken).Column("id_token");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}