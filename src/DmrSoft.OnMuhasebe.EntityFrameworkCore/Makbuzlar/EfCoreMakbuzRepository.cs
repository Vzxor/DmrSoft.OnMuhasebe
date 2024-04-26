using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Makbuzlar;

public class EfCoreMakbuzRepository:EfCoreCommonRepository<Makbuz>,IMakbuzRepository
{
    public EfCoreMakbuzRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}