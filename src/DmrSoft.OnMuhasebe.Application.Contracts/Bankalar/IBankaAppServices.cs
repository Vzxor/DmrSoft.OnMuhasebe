using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Bankalar;

public interface IBankaAppServices:ICrudAppService<SelectBankaDto,ListBankaDto,BankaListParameterDto,CreateBankaDto,UpdateBankaDto,CodeParameterDto>
{
    
}