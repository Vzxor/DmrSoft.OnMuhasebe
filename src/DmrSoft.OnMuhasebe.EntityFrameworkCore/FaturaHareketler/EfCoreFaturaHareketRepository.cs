using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using DmrSoft.OnMuhasebe.Faturalar;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.FaturaHareketler;

public class EfCoreFaturaHareketRepository:EfCoreCommonRepository<FaturaHareket>,IFaturaHareketRepository
{
    public EfCoreFaturaHareketRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}