using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Parametreler;

public class EfCoreFirmaParametreRepository:EfCoreCommonRepository<FirmaParametre>,IFirmaParametreRepository
{
    public EfCoreFirmaParametreRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}