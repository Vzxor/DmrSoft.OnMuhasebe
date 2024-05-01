using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Cariler;

public interface ICariAppServices : ICrudAppService<SelectCariDto, ListCariDto, CariListParameterDto, CreateCariDto,
    UpdateCariDto, CodeParameterDto>
{
}