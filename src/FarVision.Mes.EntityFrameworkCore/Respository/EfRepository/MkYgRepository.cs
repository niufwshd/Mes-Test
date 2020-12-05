using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MkYgRepository : EfCoreRepository<MesDbContext,MkYg, int >, IMkYgRepository
	{
		public MkYgRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}