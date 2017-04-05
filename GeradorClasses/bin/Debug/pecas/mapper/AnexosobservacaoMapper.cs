using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AnexosobservacaoMapper : ClassMapper<Anexosobservacao>
	{
		public AnexosobservacaoMapper()
		{
			//
			Schema("pecas");
			Table("anexosobservacoes");
		Map(prop => prop.IdAnexoobservacao).Column("id_anexoobservacao").Key(KeyType.Identity);  
		Map(prop => prop.CodObservacaopedido).Column("cod_observacaopedido");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
			//
		}
	}
}