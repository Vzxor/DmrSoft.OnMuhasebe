using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Depolar;

public interface IDepoAppServices : ICrudAppService<SelectDepoDto, ListDepoDto, DepoListParameterDto, CreateDepoDto,
    UpdateDepoDto, DepoCodeParameterDto>
{
}