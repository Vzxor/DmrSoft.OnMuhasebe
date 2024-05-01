using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.OzelKodlar;

public interface IOzelKodAppServices : ICrudAppService<SelectOzelKodDto, ListOzelKodDto, OzelKodListParameterDto,
    CreateOzelKodDto, UpdateOzelKodDto, OzelKodCodeParameterDto>
{
}