using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbPerfTimeservicelogRepository : EfCoreRepository<MesDbContext,TbPerfTimeservicelog, int >, ITbPerfTimeservicelogRepository
	{
		public TbPerfTimeservicelogRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}