using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LogisticaMapper : ClassMapper<Logistica>
	{
		public LogisticaMapper()
		{
			//
			Schema("pecas");
			Table("logisticas");
		Map(prop => prop.CodRetorno).Column("cod_retorno");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.PessoaContatada).Column("pessoa_contatada");  
		Map(prop => prop.IdLogistica).Column("id_logistica");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.DataAbertura).Column("data_abertura");  
		Map(prop => prop.MotivoReabertura).Column("motivo_reabertura");  
		Map(prop => prop.CodFormacontato).Column("cod_formacontato");  
		Map(prop => prop.DataFechamento).Column("data_fechamento");  
		Map(prop => prop.DataNovoContato).Column("data_novo_contato");  
			//
		}
	}
}