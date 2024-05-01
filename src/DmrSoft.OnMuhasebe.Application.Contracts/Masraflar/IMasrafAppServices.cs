using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Masraflar;

public interface IMasrafAppServices : ICrudAppService<SelectMasrafDto, ListMasrafDto, MasrafListParameterDto,
    CreateMasrafDto, UpdateMasrafDto, CodeParameterDto>
{
}