using DmrSoft.OnMuhasebe.Bankalar;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.BankaSubeler;

public interface IBankaAppServices : ICrudAppService<SelectBankaSubeDto, ListBankaSubeDto, BankaListParameterDto,
    CreateBankaSubeDto, UpdateBankaSubeDto, BankaSubeCodeParameterDto>
{
}