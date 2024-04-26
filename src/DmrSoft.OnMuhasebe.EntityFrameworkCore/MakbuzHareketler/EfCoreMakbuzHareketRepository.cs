using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using DmrSoft.OnMuhasebe.Makbuzlar;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.MakbuzHareketler;

public class EfCoreMakbuzHareketRepository:EfCoreCommonRepository<MakbuzHareket>
{
    public EfCoreMakbuzHareketRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}