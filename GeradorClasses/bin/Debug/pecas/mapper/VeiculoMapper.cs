using DapperExtensions.Mapper; 
namespace Prismatec{
	public class VeiculoMapper : ClassMapper<Veiculo>
	{
		public VeiculoMapper()
		{
			//
			Schema("pecas");
			Table("veiculos");
		Map(prop => prop.CodCombustivel).Column("cod_combustivel");  
		Map(prop => prop.Observacao).Column("observacoes");  
		Map(prop => prop.AnoModelo).Column("ano_modelo");  
		Map(prop => prop.Tipo).Column("tipo");  
		Map(prop => prop.Placa).Column("placa");  
		Map(prop => prop.Modelo).Column("modelo");  
		Map(prop => prop.Km).Column("km");  
		Map(prop => prop.Porta).Column("portas");  
		Map(prop => prop.CodProprietario).Column("cod_proprietario");  
		Map(prop => prop.Combustivel).Column("combustivel");  
		Map(prop => prop.PinturaCor).Column("pintura_cor");  
		Map(prop => prop.CodSeguro).Column("cod_seguro");  
		Map(prop => prop.StringImportacao).Column("string_importacao");  
		Map(prop => prop.PinturaTipo).Column("pintura_tipo");  
		Map(prop => prop.Motor).Column("motor");  
		Map(prop => prop.AnoFabricacao).Column("ano_fabricacao");  
		Map(prop => prop.IdVeiculo).Column("id_veiculo").Key(KeyType.Identity);  
		Map(prop => prop.Chassi).Column("chassi");  
		Map(prop => prop.CodMarca).Column("cod_marca");  
		Map(prop => prop.CodSinistro).Column("cod_sinistro");  
			//
		}
	}
}