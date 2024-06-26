﻿using DmrSoft.OnMuhasebe.Commons;
using DmrSoft.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DmrSoft.OnMuhasebe.BankaSubeler;

public class EfCoreBankaSubeRepository:EfCoreCommonRepository<BankaSube>,IBankaSubeRepository
{
    public EfCoreBankaSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}