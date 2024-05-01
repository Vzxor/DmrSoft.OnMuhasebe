using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Subeler;

public interface ISubeAppServices : ICrudAppService<SelectSubeDto, ListSubeDto, SubeListParameterDto, CreateSubeDto,
    UpdateSubeDto, CodeParameterDto>
{
}