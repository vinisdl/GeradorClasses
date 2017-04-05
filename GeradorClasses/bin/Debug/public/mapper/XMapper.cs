using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class XMapper : ClassMapper<X>
	{
		public XMapper()
		{
			//
			Schema("public");
			Table("x");
		Map(prop => prop.?column?).Column("?column?");  
			//
		}
	}
}