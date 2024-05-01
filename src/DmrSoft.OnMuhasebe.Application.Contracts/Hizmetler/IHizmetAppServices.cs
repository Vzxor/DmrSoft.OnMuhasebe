using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Hizmetler;

public interface IHizmetAppServices : ICrudAppService<SelectHizmetDto, ListHizmetDto, HizmetListParameterDto,
    CreateHizmetDto, UpdateHizmetDto, CodeParameterDto>
{
}