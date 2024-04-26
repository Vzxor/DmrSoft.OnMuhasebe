using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.OzelKodlar;

public class EfCoreOzelKodRepository:EfCoreCommonRepository<OzelKod>
{
    public EfCoreOzelKodRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}