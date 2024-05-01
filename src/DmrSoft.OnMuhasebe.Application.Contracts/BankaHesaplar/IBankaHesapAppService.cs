using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.BankaHesaplar;

public interface IBankaHesapAppService : ICrudAppService<SelectBankaHesapDto, ListBankaHesapDto,
    BankaHesapListParameterDto, CreateBankaHesapDto, UpdateBankaHesapDto, BankaHesapCodeParameterDto>
{
}