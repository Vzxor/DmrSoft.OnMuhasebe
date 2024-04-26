using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Kasalar;

public class EfCoreKasaRepository:EfCoreCommonRepository<Kasa>
{
    public EfCoreKasaRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
        
    }
}