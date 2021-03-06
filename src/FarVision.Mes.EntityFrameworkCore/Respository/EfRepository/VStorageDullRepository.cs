using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VStorageDullRepository : EfCoreRepository<MesDbContext,VStorageDull, int >, IVStorageDullRepository
	{
		public VStorageDullRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}