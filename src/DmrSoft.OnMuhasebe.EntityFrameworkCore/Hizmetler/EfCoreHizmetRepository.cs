using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Hizmetler;

public class EfCoreHizmetRepository:EfCoreCommonRepository<Hizmet>,IHizmetRepository
{
    public EfCoreHizmetRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}