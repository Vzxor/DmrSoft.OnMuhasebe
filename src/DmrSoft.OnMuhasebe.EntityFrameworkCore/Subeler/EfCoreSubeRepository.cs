using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.Subeler;

public class EfCoreSubeRepository:EfCoreCommonRepository<Sube>
{
    public EfCoreSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}