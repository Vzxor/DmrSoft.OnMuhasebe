using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Stoklar;

public class EfCoreStokRepository:EfCoreCommonRepository<Stok>
{
    public EfCoreStokRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}