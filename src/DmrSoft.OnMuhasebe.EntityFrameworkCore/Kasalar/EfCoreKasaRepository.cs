using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Kasalar;

public class EfCoreKasaRepository:EfCoreCommonRepository<Kasa>,IKasaRepository
{
    public EfCoreKasaRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
        
    }
}