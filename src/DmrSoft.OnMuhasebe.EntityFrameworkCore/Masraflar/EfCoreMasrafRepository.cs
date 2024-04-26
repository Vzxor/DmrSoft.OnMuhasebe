using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Masraflar;

public class EfCoreMasrafRepository:EfCoreCommonRepository<Masraf>
{
    public EfCoreMasrafRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}