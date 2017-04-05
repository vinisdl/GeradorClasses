using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SinistroMapper : ClassMapper<Sinistro>
	{
		public SinistroMapper()
		{
			//
			Schema("pecas");
			Table("sinistros");
		Map(prop => prop.Local).Column("local");  
		Map(prop => prop.DataAcidente).Column("data_acidente").Key(KeyType.Identity);  
		Map(prop => prop.CodigoVistoria).Column("codigo_vistoria");  
		Map(prop => prop.NomeAnalista).Column("nome_analista");  
		Map(prop => prop.CodAnalista).Column("cod_analista");  
		Map(prop => prop.CodCidade).Column("cod_cidade");  
		Map(prop => prop.PagamentoCancelado).Column("pagamento_cancelado");  
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.OficinaSequencial).Column("oficina_sequencial");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodSucursal).Column("cod_sucursal");  
		Map(prop => prop.IdSinistro).Column("id_sinistro");  
		Map(prop => prop.NomePerito).Column("nome_perito");  
		Map(prop => prop.DataAbertura).Column("data_abertura");  
		Map(prop => prop.CodPerito).Column("cod_perito");  
			//
		}
	}
}