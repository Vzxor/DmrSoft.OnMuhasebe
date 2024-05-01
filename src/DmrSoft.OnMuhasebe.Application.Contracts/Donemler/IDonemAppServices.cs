using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Donemler;

public interface IDonemAppServices : ICrudAppService<SelectDonemDto, ListDonemDto, DonemListParameterDto, CreateDonemDto
    , UpdateDonemDto, CodeParameterDto>
{
}