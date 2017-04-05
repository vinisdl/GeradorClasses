using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ObservacoespedidoMapper : ClassMapper<Observacoespedido>
	{
		public ObservacoespedidoMapper()
		{
			//
			Schema("pecas");
			Table("observacoespedidos");
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.Automatica).Column("automatica");  
		Map(prop => prop.Oficina).Column("oficina");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.CriacaoIp).Column("criacao_ip");  
		Map(prop => prop.Conteudo).Column("conteudo");  
		Map(prop => prop.Integrar).Column("integrar");  
		Map(prop => prop.TipoObservacao).Column("tipo_observacao");  
		Map(prop => prop.IdObservacaopedido).Column("id_observacaopedido");  
			//
		}
	}
}